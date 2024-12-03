using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Application.CQRS.Commands
{
    public class ProjectUpdateCommand
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Url]
        [Required]
        public string UrlGit { get; set; }
        public HashSet<string> Tags { get; set; } = new();

        [JsonIgnore]
        public DateTime CreateddAt { get; set; }

        [JsonIgnore]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
