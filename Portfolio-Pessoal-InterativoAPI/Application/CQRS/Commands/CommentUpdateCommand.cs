﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Commands
{
    public class CommentUpdateCommand
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
