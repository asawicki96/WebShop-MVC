using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.DAL;
using Shop.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class ProductsController : Controller
    {
        private WebShopContext db = new WebShopContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string? categoryName, string? searchQuery, int? page)
        {

            var categories = db.Categories.ToList();
            var viewModel = new HomeViewModel 
            {
                Categories = categories
            };

            if (categoryName != null)
            {
                var category = db.Categories.Include("Products").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).Single();
                var products = category.Products.ToList().OrderByDescending(p => p.CreatedAt);
                viewModel.Newests = products;
                ViewBag.categoryName = categoryName.ToUpper();
            }
            else
            {
                var products = db.Products.Where(p => p.IsActive == true).OrderByDescending(p => p.CreatedAt).Take(9).ToList();
                viewModel.Newests = products;
            }
            

            if (searchQuery != null)
            {
                var products = this.db.Products.Where(p => p.Name.ToLower().Contains(searchQuery.ToLower()));
                viewModel.Newests = products;
                ViewBag.searchQuery = searchQuery;
            }
            

            return View(viewModel);
        }

        public IActionResult Detail(int id)
        {
            var product = db.Products.Find(id);
            var categories = db.Categories.ToList();
            var viewModel = new ProductDetailViewModel
            {
                Product = db.Products.Find(id),
                Categories = db.Categories.ToList()
            };
            return View(viewModel);
        }

        [System.Web.Mvc.ChildActionOnly]
        public ActionResult CategoriesMenu(IEnumerable <Category> categories)
        {
            return PartialView("_CategoriesMenu", categories);
        }

        [System.Web.Mvc.ChildActionOnly]
        public ActionResult ProductsList(IEnumerable <Product> products)
        {
            return PartialView("_ProductsList", products);
        }
    }
}
