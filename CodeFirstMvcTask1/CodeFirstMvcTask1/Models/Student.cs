using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstMvcTask1.Models
{
    public class Student
    {
        [Key]

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual StudentDetails Details { get; set; }

    }
}