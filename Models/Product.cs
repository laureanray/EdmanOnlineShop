using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace EdmanOnlineShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Product Name field is required")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Product Description field is required")]
        public string ProductDescription { get; set; }

        public byte[] ProductImage { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Required]

        public decimal Price { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        public DateTime? DateModified { get; set; }
        [Range(0, 110, ErrorMessage = "<Categoasdry type is required.")]
        [Required(ErrorMessage = "Category type is required. ")]
        public int CategoryID { get; set; }
        
        public bool IsArchived { get; set; }
    }
}