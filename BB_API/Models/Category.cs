﻿using System.ComponentModel.DataAnnotations;

namespace BB_API.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
    }
}
