using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPage.Models
{
    public class Resturant
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Title { get; set; }
        [Required, StringLength(800)]
        public string Context { get; set; }
        public string RestImage { get; set; }

    }
}
