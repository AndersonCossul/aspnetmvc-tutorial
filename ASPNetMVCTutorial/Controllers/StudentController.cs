using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNetMVCTutorial.Models;

namespace ASPNetMVCTutorial.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var studentList = new List<Student>
            {
                new Student() { ID = 1, Name = "John", Age = 18 } ,
                new Student() { ID = 2, Name = "Steve",  Age = 21 } ,
                new Student() { ID = 3, Name = "Bill",  Age = 25 } ,
                new Student() { ID = 4, Name = "Ram" , Age = 20 } ,
                new Student() { ID = 5, Name = "Ron" , Age = 31 } ,
                new Student() { ID = 4, Name = "Chris" , Age = 17 } ,
                new Student() { ID = 4, Name = "Rob" , Age = 19 },
                new Student() { ID = 4, Name = "Anderson" , Age = 20 },
            };
            return View(studentList);
        }

        public string Create()
        {
            return "My theory was right after all!";
        }
    }
}