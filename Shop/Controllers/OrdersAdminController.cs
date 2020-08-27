using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.WebPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.DAL;
using Shop.Infrastructrue;
using Shop.Models;


namespace Shop.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class OrdersAdminController : Controller
    {
        private readonly WebShopContext db;
        public OrdersAdminController(WebShopContext _db)
        {
            db = _db;
        }

        // GET: OrdersAdmin
        public IActionResult Index(int? pageNumber)
        {
            var pageSize = 10;
            var orders = db.Orders.OrderByDescending(o => o.CreatedAt);
            return View(PaginatedList<Order>.Create(orders.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: OrdersAdmin/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = db.Orders
                .FirstOrDefault(m => m.OrderId == id);
            var items = db.Items.Where(i => i.OrderId == order.OrderId);
           
            order.Items = items.ToList();
            foreach(OrderItem item in order.Items)
            {
                item.Product = db.Products.Find(item.ProductId);
            }

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }


        public IActionResult AddOrderItem(int? pageNumber, int orderId)
        {
            ViewBag.orderId = orderId;
            var pageSize = 10;
            var products = db.Products.OrderByDescending(p => p.CreatedAt);
            return View(PaginatedList<Product>.Create(products.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        public IActionResult Add(int orderId, int productId)
        {
            var product = db.Products.Find(productId);
            var order = db.Orders.Find(orderId);

            if (product == null || order == null)
                return RedirectToAction("AddOrderItem", new { orderId = orderId });

            OrderItem item = new OrderItem()
            {
                OrderId = orderId,
                ProductId = productId,
                TotalPrice = product.Price
            };

            db.Items.Add(item);

            order.Price = order.Price + item.TotalPrice;
            db.Orders.Update(order);
            db.SaveChanges();
            return RedirectToAction("Details", new { id = orderId });
        }


        // GET: OrdersAdmin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrdersAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,FirstName,LastName,Address,City,PostalCode,Email,Comment,CreatedAt,State,Price")] Order order)
        {
            if (ModelState.IsValid)
            {
                order.CreatedAt = DateTime.Now;
                db.Orders.Add(order);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: OrdersAdmin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await db.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: OrdersAdmin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,FirstName,LastName,Address,City,PostalCode,Email,Comment,CreatedAt,State,Price")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var old_order = db.Orders.Find(id);
                order.CreatedAt = old_order.CreatedAt;
                db.Entry(old_order).State = EntityState.Detached;
                try
                {
                    db.Orders.Update(order);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        [Route("OrdersAdmin/DelereOrderItem/{id}")]
        public async Task<IActionResult> DeleteOrderItem(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = db.Items.Find(id);
            if (orderItem == null)
            {
                return NotFound();
            }

            var order = db.Orders.Find(orderItem.OrderId);
            order.Price = (order.Price.AsDecimal() - orderItem.TotalPrice.AsDecimal()).ToString();
            db.Orders.Update(order);

            db.Items.Remove(orderItem);
            await db.SaveChangesAsync();
            return RedirectToAction("Details", new { id = orderItem.OrderId });

        }

        // GET: OrdersAdmin/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = db.Orders
                .FirstOrDefault(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: OrdersAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var order = db.Orders.Find(id);
            db.Orders.Remove(order);

            var orderItems = db.Items.Where(i => i.OrderId == order.OrderId).ToList();

            foreach(OrderItem item in orderItems)
            {
                db.Items.Remove(item);
            }

            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return db.Orders.Any(e => e.OrderId == id);
        }
    }
}
