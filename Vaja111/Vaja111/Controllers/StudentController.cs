using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vaja111.Models;

namespace Vaja111.Controllers
{
    public class StudentController : Controller
    {
        List<Student> studentList = new List<Student>
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Johnny", Age = 19 } ,
                new Student() { StudentID = 3, StudentName = "Johnney", Age = 20 } ,
                new Student() { StudentID = 4, StudentName = "Johnneyson", Age = 21 }
            };

        // GET: Student
        public ActionResult Index()
        {
            return View(studentList);
        }

        public ActionResult Edit(int id)
        {
            var student = studentList.Where(s => s.StudentID == id).FirstOrDefault();
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            if (ModelState.IsValid)
            {
                // posodobi podatke
                return RedirectToAction("Index");
            }
            return View(std);
        }
    }
}