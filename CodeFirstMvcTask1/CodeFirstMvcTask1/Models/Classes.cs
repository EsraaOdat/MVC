using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstMvcTask1.Models
{
    public class Classes
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }


        public virtual Teacher Teacher { get; set; }

    }
}