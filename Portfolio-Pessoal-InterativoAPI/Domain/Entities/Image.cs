﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Image
    {
        public Guid Id { get; set; }
        public string? Url { get; set; }
        public string? Base64Data { get; set; }
        public string? Description { get; set; }
    }
}
