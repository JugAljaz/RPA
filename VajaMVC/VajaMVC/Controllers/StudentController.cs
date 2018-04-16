using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VajaMVC.Models;

namespace VajaMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var studentList = new List<Student>{
                new Student() { StudentId = 1, StudentName = "Jožef", Age = 18 },
                new Student() { StudentId = 2, StudentName = "John Bon Johvi", Age = 19 },
                new Student() { StudentId = 3, StudentName = "Miharocket", Age = 20 },
                new Student() { StudentId = 4, StudentName = "Džek", Age = 16 },
                new Student() { StudentId = 5, StudentName = "Kjpca", Age = 69 }
            };
            return View(studentList);
        }
    }
}