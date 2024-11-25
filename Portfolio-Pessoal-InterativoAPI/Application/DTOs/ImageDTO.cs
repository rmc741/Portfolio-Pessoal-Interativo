namespace Application.DTOs
{
    public class ImageDTO
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string? Base64Data { get; set; }
        public string? Description { get; set; }
    }
}
