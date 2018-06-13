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
        private List<Student> studentList;

        public StudentController()
        {
            studentList = new List<Student>
            {
                new Student() { ID = 1, Name = "John", Age = 18 } ,
                new Student() { ID = 2, Name = "Steve",  Age = 21 } ,
                new Student() { ID = 3, Name = "Bill",  Age = 25 } ,
                new Student() { ID = 4, Name = "Ram" , Age = 20 } ,
                new Student() { ID = 5, Name = "Ron" , Age = 31 } ,
                new Student() { ID = 6, Name = "Chris" , Age = 17 } ,
                new Student() { ID = 7, Name = "Rob" , Age = 19 },
                new Student() { ID = 8, Name = "Anderson" , Age = 20 },
            };
        }

        // GET: Student
        public ActionResult Index()
        {
            return View(studentList);
        }

        public ActionResult Edit(int id)
        {
            var student = studentList.Where(item => item.ID == id).FirstOrDefault();
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                // note: this is useless as everytime we change routes the constructor is called and resets the list.
                var index = studentList.FindIndex(i => i.ID == student.ID);
                studentList[index] = student;
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}