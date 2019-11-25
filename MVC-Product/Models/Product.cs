using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Product.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}