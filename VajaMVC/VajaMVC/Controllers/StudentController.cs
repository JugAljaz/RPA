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
        List<Student> studentList = new List<Student>{
                new Student() { StudentId = 1, StudentName = "Jožef", Age = 18 },
                new Student() { StudentId = 2, StudentName = "John Bon Johvi", Age = 19 },
                new Student() { StudentId = 3, StudentName = "Miharocket", Age = 20 },
                new Student() { StudentId = 4, StudentName = "Džemo", Age = 16 },
                new Student() { StudentId = 5, StudentName = "Kjpca", Age = 69 }
            };
        // GET: Student
        public ActionResult Index()
        {
            return View(studentList);
        }
        public ActionResult Edit(int id)
        {
            var študent = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(študent);
        }
        [HttpPost]
        public ActionResult Edit (Student std)
        {
            if (ModelState.IsValid)
            {
                //posodobi podatke
                return RedirectToAction("Index");
            }
            return View(std);
        }
    }
}