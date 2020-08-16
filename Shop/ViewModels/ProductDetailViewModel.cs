using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Models;

namespace Shop.ViewModels
{
    public class ProductDetailViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public Product Product { get; set; }

    }
}
