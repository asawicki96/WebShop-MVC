using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Shop.Infrastructrue;
using Shop.Models;
using Shop.DAL;

namespace Shop.Controllers
{
    public class CartController : Controller
    {
        private WebShopContext db = new WebShopContext();
        public IActionResult Detail()
        {
            var cart = CartManager.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            if(cart != null)
            {
                ViewBag.total = cart.Sum(item => item.Product.Price);
            }
            return View();
        }

        public IActionResult AddToCart(int id)
        {
            Product product = db.Products.Find(id);
            if (CartManager.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart") == null)
            {
                List<CartItem> cart = new List<CartItem>();

                cart.Add(new CartItem { Product = product, Price=product.Price });
                CartManager.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<CartItem> cart = CartManager.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
                
                cart.Add(new CartItem { Product = product, Price = product.Price });

                CartManager.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Detail");
        }

        public IActionResult RemoveItem(int id)
        {
            List<CartItem> cart = CartManager.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            CartManager.SetObjectAsJson(HttpContext.Session, "cart", cart);
            
            return RedirectToAction("Detail");
        }

        private int isExist(int id)
        {
            List<CartItem> cart = CartManager.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductId.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
