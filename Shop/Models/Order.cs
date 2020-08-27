using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100)]
        public string Address { get; set; }
        [Required(ErrorMessage = "City name is required")]
        [StringLength(100)]
        public string City { get; set; }
        [Required(ErrorMessage = "Postal code is required")]
        [StringLength(6)]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [StringLength(50)]
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public State State { get; set; }
        [RegularExpression(@"(?!^0*$)(?!^0*\.0*$)^\d{1,5}(\,\d{1,2})?$", ErrorMessage = "Price must be like 19,99")]
        public string Price { get; set; }
        public List<OrderItem> Items { get; set; }
    }

    public enum State
    {
        New,
        Executed
    }
}
