using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Shop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product's name is required")]
        [StringLength(100)]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        [StringLength(100)]
        public string Image { get; set; }

        [Range(0, 999.99)]
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

        [JsonIgnore]
        public virtual Category Category { get; set; }
        [NotMapped]
        public virtual IFormFile File { get; set; }

    }
}
