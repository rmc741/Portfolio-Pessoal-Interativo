namespace Domain.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        //public Guid UserId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
