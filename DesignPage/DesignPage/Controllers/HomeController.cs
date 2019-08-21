using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPage.DAL;
using DesignPage.Models;
using DesignPage.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DesignPage.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            HomePageComponents homePageComponents = new HomePageComponents
            {
                Slider = _context.Sliders,
                AboutUs = _context.AboutUses,
                Resturants = _context.Resturants,
                SliderAdvances = _context.SliderAdvances,
                Parallaxes = _context.Parallaxes


            };
            return View(homePageComponents);
        }
    }
}