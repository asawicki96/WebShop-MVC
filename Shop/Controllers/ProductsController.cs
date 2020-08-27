using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shop.DAL;
using Shop.Models;
using Shop.ViewModels;
using Shop.Infrastructrue;
using Microsoft.EntityFrameworkCore;

namespace Shop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly WebShopContext db;
        public ProductsController(WebShopContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string? categoryName, string? searchQuery, int? pageNumber)
        {
            int pageSize = 6;
            var categories = this.db.Categories.ToList();
            var viewModel = new HomeViewModel 
            {
                Categories = categories
            };

            if (categoryName != null)
            {
                var category = db.Categories.Include("Products").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).Single();
                var products = category.Products.ToList().OrderByDescending(p => p.CreatedAt).AsQueryable();
                viewModel.Newests = PaginatedList<Product>.Create(products.AsNoTracking(), pageNumber ?? 1, pageSize);
                ViewBag.categoryName = categoryName.ToUpper();
            }
            else
            {
                var products = db.Products.Where(p => p.IsActive == true).OrderByDescending(p => p.CreatedAt).Take(9);
                viewModel.Newests = PaginatedList<Product>.Create(products.AsNoTracking(), pageNumber ?? 1, pageSize);
            }
            

            if (searchQuery != null)
            {
                var products = db.Products.Where(p => p.Name.ToLower().Contains(searchQuery.ToLower())).OrderByDescending(p => p.CreatedAt);
                viewModel.Newests = PaginatedList<Product>.Create(products.AsNoTracking(), pageNumber ?? 1, pageSize);
                ViewBag.searchQuery = searchQuery;
            }
            return View(viewModel);
        }

        public IActionResult Detail(int id)
        {
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
