using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using p224FrontToBack.DAL;
using p224FrontToBack.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace p224FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = _context.Sliders.ToList(),
                Caption = _context.Captions.FirstOrDefault(),
                Categories = _context.Categories.ToList(),
                Products = _context.Products.Include(p => p.Category).OrderByDescending(p => p.Id).Take(8).ToList(),
                About = _context.About.FirstOrDefault()
            };
            return View(homeVM);
        }
    }
}
