using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.WebPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DAL;
using Shop.Infrastructrue;
using Shop.Models;

namespace Shop.Controllers
{

    public class OrderController : Controller
    {
        private readonly WebShopContext db;
        public OrderController(WebShopContext _db)
        {
            db = _db;
        }
        // GET: OrderController/Create
        public ActionResult Create()
        {
            var cart = CartManager.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            if (cart != null && cart.Count > 0)
            {
                ViewBag.total = cart.Sum(item => item.Product.Price.AsDecimal());
                return View();
            }
            else
            {
                return RedirectToAction("List", "Products");
            }
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,FirstName,LastName,Address,City,PostalCode,Email,Comment,CreatedAt,State,Price,Items")] Order order)
        {
            if (ModelState.IsValid)
            {
                order.CreatedAt = DateTime.Now;

                var cart = CartManager.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
                order.Price = cart.Sum(item => item.Product.Price.AsDecimal()).ToString();

                db.Orders.Add(order);
                db.SaveChanges();

                foreach (CartItem item in cart)
                {
                    var orderItem = new OrderItem()
                    {
                        OrderId = order.OrderId,
                        ProductId = item.Product.ProductId,
                        Quantity = 1,
                        TotalPrice = item.Price
                    };

                    db.Items.Add(orderItem);
                }

                await db.SaveChangesAsync();
                HttpContext.Session.Clear();
                return RedirectToAction("List", "Products");
            }
            else
            {
                return View(order);
            }
        }
    }    
}
