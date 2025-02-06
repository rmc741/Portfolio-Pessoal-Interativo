using Application.DTOs;
using Application.Interfaces.Services;
using Domain.Entities;
using Domain.Interface.Repository;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepositorty _authRepository;
        private readonly string _secretKey;
        private readonly string _issuer;
        private readonly string _audience;

        public AuthService(IAuthRepositorty authRepository, string secretKey,
            string issuer, string audience)
        {
            _authRepository = authRepository;
            _secretKey = secretKey;
            _issuer = issuer;
            _audience = audience;
        }

        public async Task<TokenDTO> Login(LoginDTO loginRequest)
        {
            User user = await _authRepository.VerifyUser(loginRequest.UserName, loginRequest.Password);

            if (user != null)
            {
                var token = GenerateToken(user);
                return token;
            }
            return null;
        }

        private TokenDTO GenerateToken(User user)
        {
            //declarações do usuário
            var claims = new[]
            {
            new Claim("email", user.Email),
            new Claim("meuvalor", "oque voce quiser"),
            //new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

            //gerar chave privada para assinar o token
            var privateKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_secretKey));

            //gerar a assinatura digital
            var credentials = new SigningCredentials(privateKey, SecurityAlgorithms.HmacSha256);

            //definir o tempo de expiração
            var expiration = DateTime.UtcNow.AddMinutes(10);

            //gerar o token
            JwtSecurityToken token = new JwtSecurityToken(
                //emissor
                issuer: _issuer,
                //audiencia
                audience: _audience,
                //claims
                claims: claims,
                //data de expiracao
                expires: expiration,
                //assinatura digital
                signingCredentials: credentials
                );

            return new TokenDTO()
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                ExpiresIn = expiration
            };
        }

    }
}
