using DesignPage.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPage.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<AboutUs> AboutUses { get; set; }
        public DbSet<Resturant> Resturants { get; set; }
        public DbSet<SliderAdvance> SliderAdvances { get; set; }
        public DbSet<Parallax> Parallaxes { get; set; }
    }
 
}
