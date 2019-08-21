using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPage.Models
{
    public class SliderAdvance
    {

        public int Id { get; set; }

        [Required, StringLength(255)]
        public string BigImage { get; set; }
        [Required, StringLength(255)]
        public string SmallImage { get; set; }
        [Required, StringLength(255)]
        public string Title { get; set; }
        [Required, StringLength(600)]
        public string Context { get; set; }
        [Required, StringLength(255)]
        public string Button { get; set; }
       
        public string Active { get; set; }
    }
}
