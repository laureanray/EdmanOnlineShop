using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EdmanOnlineShop.Models;
using Microsoft.AspNetCore.Http;

namespace EdmanOnlineShop.ViewModels
{
    public class ArchiveProductViewModel
    {
        public int ProductID { get; set; }
        public List<Category> Categories { get; set;} = new List<Category>();
        [Required(ErrorMessage = "Product Name field is required")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Product Description field is required")]
        public string ProductDescription { get; set; }
        public IFormFile ProductImage { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        [Range(0, 9999999999.99, ErrorMessage = "Must be positive numbers only. ")]
        public decimal Price { get; set; }
        [Range(0, 110, ErrorMessage = "Category type is required.")]
        [Required(ErrorMessage = "Category type is required. ")]
        public int CategoryID { get; set; }
        
        public bool IsArchived { get; set; }
    }
}