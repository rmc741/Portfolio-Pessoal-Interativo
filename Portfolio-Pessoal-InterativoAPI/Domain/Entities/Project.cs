﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UrlGit { get; set; }
        public HashSet<string> Tags { get; set; } = new();
        public List<Comment>? CommentsList { get; set; } = new();
        public List<Image>? ImagesList { get; set; } = new();
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
