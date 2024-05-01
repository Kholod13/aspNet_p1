﻿using System.ComponentModel.DataAnnotations;
using UseThi.Data.Entities;

namespace UseThi.Models
{
    public class ProductFormModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int Discount { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public string? Location { get; set; }
        public string? Contact { get; set; }

        public int CategoryId { get; set; }

        // ------- navigation property
        public Category? Category { get; set; }
    }

    public class ProductCartModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int Discount { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public string? Location { get; set; }
        public string? Contact { get; set; }

        public int CategoryId { get; set; }

        // ------- navigation property
        public Category? Category { get; set; }
    }
}