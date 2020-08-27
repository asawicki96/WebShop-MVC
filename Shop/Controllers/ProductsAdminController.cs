using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shop.Models;
using Shop.DAL;
using System.Data.Entity.Migrations;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Hosting;
using System.IO;
using Shop.Infrastructrue;
using Microsoft.AspNetCore.Authorization;

namespace Shop.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class ProductsAdminController : Controller
    {
        private readonly WebShopContext db = new WebShopContext();

        // GET: ProductsAdmin
        public IActionResult Index(int? pageNumber)
        {
            var pageSize = 10;
            var shopContext = db.Products.Include(p => p.Category).OrderByDescending(p => p.CreatedAt);
            ViewBag.model = new Product();
            return View(PaginatedList<Product>.Create(shopContext.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: ProductsAdmin/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = db.Products
                .Include(p => p.Category)
                .FirstOrDefault(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: ProductsAdmin/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(db.Set<Category>(), "CategoryId", "Name");
            return View();
        }

        // POST: ProductsAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,Name,CategoryId,Description,Image,Price,CreatedAt,IsActive,File")] Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.File != null && product.File.Length > 0)
                {
                    
                    var fileName = $@"{Guid.NewGuid()}.png"; ;
                    
                    var filePath = Path.Combine("wwwroot/Content/Products/",fileName);
                    product.Image = fileName;

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await product.File.CopyToAsync(stream);
                    }
                }
                
                product.CreatedAt = DateTime.Now;
                product.IsActive = true;
                db.Products.Add(product);
                await db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(db.Set<Category>(), "CategoryId", "Name", product.CategoryId);
            return View(product);
        }

        // GET: ProductsAdmin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await db.Products.FindAsync(id);
            
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(db.Set<Category>(), "CategoryId", "Name", product.CategoryId);
            return View(product);
        }

        // POST: ProductsAdmin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,Name,CategoryId,Description,Image,Price,CreatedAt,IsActive,File")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var old_product = db.Products.Find(id);
                product.CreatedAt = old_product.CreatedAt;

                if (product.File != null && product.File.Length > 0)
                {

                    var fileName = old_product.Image;

                    var filePath = Path.Combine("wwwroot/Content/Products/", fileName);
                    product.Image = fileName;

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await product.File.CopyToAsync(stream);
                    }
                }
                else
                {
                    product.Image = old_product.Image;
                }

                try
                {
                    db.Products.AddOrUpdate(product);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
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
            ViewData["CategoryId"] = new SelectList(db.Set<Category>(), "CategoryId", "Name", product.CategoryId);
            return View(product);
        }

        // GET: ProductsAdmin/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = db.Products
                .Include(p => p.Category)
                .FirstOrDefault(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: ProductsAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await db.Products.FindAsync(id);
            var fileName = product.Image;

            if (fileName != null)
            {
                var filePath = Path.Combine("wwwroot/Content/Products/", fileName);
                System.IO.File.Delete(filePath);
            }
            
            db.Products.Remove(product);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return db.Products.Any(e => e.ProductId == id);
        }
    }
}
