using Application.DTOs;
using System.ComponentModel.DataAnnotations;

namespace Application.CQRS.Commands
{
    public class ProjectUpdateCommand
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Url]
        [Required]
        public string UrlGit { get; set; }
        public HashSet<string> Tags { get; set; } = new();
        public List<ImageDTO>? ImagesList { get; set; } = new();
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
