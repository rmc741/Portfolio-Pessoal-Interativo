namespace Application.DTOs
{
    public class TokenDTO
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; } = "Bearer";
        public DateTime ExpiresIn { get; set; }
    }
}
