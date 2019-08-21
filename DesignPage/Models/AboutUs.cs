using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPage.Models
{
    public class AboutUs
    {
        public int Id { get; set; }
        [Required, StringLength(150)]
        public string ClassName { get; set; }
        [Required, StringLength(255)]
        public string Icon { get; set; }
        [Required, StringLength(150)]
        public string Title { get; set; }
        [Required, StringLength(600)]
        public string Information { get; set; }
        [Required,StringLength(150)]
        public string Position { get; set; }
    }
}
