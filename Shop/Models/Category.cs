using Microsoft.AspNetCore.Http;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Shop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category's name is required")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Category's description is required")]
        public string Description { get; set; }
        public string Icon { get; set; }

        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }
        public virtual IFormFile IconFile { get; set; }

    }
}