using System.ComponentModel.DataAnnotations;

namespace Application.CQRS.Commands
{
    public class CommentCreateCommand
    {
        [Required]
        public Guid ProjectId { get; set; }
        //public Guid UserId { get; set; }

        [Required]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
