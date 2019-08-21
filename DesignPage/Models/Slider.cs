using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPage.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required, StringLength(400)]
        public string DesEm { get; set; }
        [Required, StringLength(255)]
        public string DesP { get; set; }
        [Required, StringLength(255)]
        public string Image { get; set; }
        
        public string Active { get; set; }
    }
}
