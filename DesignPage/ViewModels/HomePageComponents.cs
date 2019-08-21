using DesignPage.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPage.ViewModels
{
    public class HomePageComponents
    {
        public IEnumerable<Slider> Slider {get; set;}
        public IEnumerable<AboutUs> AboutUs { get; set; }
        public IEnumerable<Resturant> Resturants { get; set; }
        public IEnumerable<SliderAdvance> SliderAdvances { get; set; }
        public DbSet<Parallax> Parallaxes { get; internal set; }
    }
}
