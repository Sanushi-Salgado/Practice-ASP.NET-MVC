using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class StudentsController : Controller      
    {

        static List<Student> studentList = new List<Student>();

        // GET: Students
        public ActionResult Index()
        {
            studentList.Add(new Student(1, "John", 18));
            studentList.Add(new Student(3, "Bill", 25));
            studentList.Add(new Student(4, "Ram", 20));
            studentList.Add(new Student(5, "Ron", 31));
            return View(studentList);
        }


        [HttpPost]
        public ActionResult AddStudent(int Id, string Name, int Age)
        {
            // Add the new student to the students' list
            studentList.Add( new Student(Id, Name, Age) );
            return Content("New student added successfully");
        }

        public ActionResult GetStudent()
        {
            Student student = new Student(6, "Sanushi", 23);
            return View(student);
        }

        
    }
}