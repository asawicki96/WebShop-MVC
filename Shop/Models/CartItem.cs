using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public string Price { get; set; }
    }
}
