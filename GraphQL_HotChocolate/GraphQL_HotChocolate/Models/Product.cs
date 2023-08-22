﻿using System.ComponentModel.DataAnnotations;

namespace GraphQL_HotChocolate.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
