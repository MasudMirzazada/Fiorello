using Microsoft.AspNetCore.Mvc;
using p224FrontToBack.DAL;
using p224FrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace p224FrontToBack.ViewComponents
{
    public class ProductViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public ProductViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Product> model = _context.Products.Take(take).OrderByDescending(p=>p.Id).ToList();
            return View(await Task.FromResult(model));
        }
    }
}
