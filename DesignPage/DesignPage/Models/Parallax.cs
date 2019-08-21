using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPage.Models
{
    public class Parallax
    {
        public int Id { get; set; }

        public int Start { get; set; }
        public int End { get; set; }
        public int Set { get; set; }
    }

}
