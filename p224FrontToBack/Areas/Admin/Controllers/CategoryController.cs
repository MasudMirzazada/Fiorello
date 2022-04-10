using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using p224FrontToBack.DAL;
using p224FrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace p224FrontToBack.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult>Index()
        {
            return View( await _context.Categories.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult>Create(Category category)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.Categories.Any(ct => ct.Name.ToLower().Trim() == category.Name.Trim());
          if(isExist)
            {
                ModelState.AddModelError("Name","Bu adda category Movcuddur");
                return View();            }
          await  _context.Categories.AddAsync(category);
         await    _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }  
        public async Task<IActionResult>Detail(int ? id)
        {
            if (id == null) return NotFound();
Category category=await _context.Categories.FirstOrDefaultAsync<c=>c.Id==Id>
        }
    }
}
