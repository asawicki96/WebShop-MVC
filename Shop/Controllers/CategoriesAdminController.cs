using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.DAL;
using Shop.Models;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Shop.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class CategoriesAdminController : Controller
    {
        private readonly WebShopContext db;
        public CategoriesAdminController(WebShopContext _db)
        {
            db = _db;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
            return View(await db.Categories.ToListAsync());
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await db.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,Name,Description,IconFile")] Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.IconFile != null && category.IconFile.Length > 0)
                {

                    var fileName = $@"{Guid.NewGuid()}.png"; ;

                    var filePath = Path.Combine("wwwroot/Content/Categories/", fileName);
                    category.Icon = fileName;

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await category.IconFile.CopyToAsync(stream);
                    }
                }
                db.Categories.Add(category);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await db.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryId,Name,Description,IconFile")] Category category)
        {
            if (id != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var old_category = db.Categories.Find(id);
                
                if (category.IconFile != null && category.IconFile.Length > 0)
                {
                    var fileName = old_category.Icon;

                    var filePath = Path.Combine("wwwroot/Content/Categories/", fileName);
                    category.Icon = fileName;

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await category.IconFile.CopyToAsync(stream);
                    }
                }
                else
                {
                    category.Icon = old_category.Icon;
                }

                db.Entry(old_category).State = EntityState.Detached;
                db.Categories.Update(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await db.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await db.Categories.FindAsync(id);
            var fileName = category.Icon;

            if (fileName != null)
            {
                var filePath = Path.Combine("wwwroot/Content/Categories/", fileName);
                System.IO.File.Delete(filePath);
            }

            db.Categories.Remove(category);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return db.Categories.Any(e => e.CategoryId == id);
        }
    }
}
