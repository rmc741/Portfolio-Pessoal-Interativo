using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class CommentDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid ProjectId { get; set; }

        //public Guid UserId { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set;}
    }
}
