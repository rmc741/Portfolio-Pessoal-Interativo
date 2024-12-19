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

        public AuthService(IAuthRepositorty authRepository)
        {
            _authRepository = authRepository;
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
            new Claim("email", userInfo.Email),
            new Claim("meuvalor", "oque voce quiser"),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

            //gerar chave privada para assinar o token
            var privateKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["Jwt:SecretKey"]));

            //gerar a assinatura digital
            var credentials = new SigningCredentials(privateKey, SecurityAlgorithms.HmacSha256);

            //definir o tempo de expiração
            var expiration = DateTime.UtcNow.AddMinutes(10);

            //gerar o token
            JwtSecurityToken token = new JwtSecurityToken(
                //emissor
                issuer: _configuration["Jwt:Issuer"],
                //audiencia
                audience: _configuration["Jwt:Audience"],
                //claims
                claims: claims,
                //data de expiracao
                expires: expiration,
                //assinatura digital
                signingCredentials: credentials
                );

            return new TokenDTO()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        }

    }
}
