using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class ProjectDTO
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Url]
        [Required]
        public string UrlGit { get; set; }
        public HashSet<string> Tags { get; set; } = new();
        public List<CommentDTO>? CommentsList { get; set; } = new();
        public List<ImageDTO>? ImagesList { get; set; } = new();
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
