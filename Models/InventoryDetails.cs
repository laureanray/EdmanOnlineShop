using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace EdmanOnlineShop.Models
{
    public class InventoryDetails
    {
        public Product Product { get; set; }
        public Category Category { get; set; }
        public Inventory Inventory { get; set; }
    }
}