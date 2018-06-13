using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetMVCTutorial.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Hey, don't forget the name.")]
        public string Name { get; set; }
        [Range(5, 50)]
        public int Age { get; set; }
    }
}