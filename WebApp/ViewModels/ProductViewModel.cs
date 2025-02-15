﻿using Entities;

namespace RiraTask.WebApp.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Categories Category { get; set; }
        public decimal Price { get; set; }
    }
}
