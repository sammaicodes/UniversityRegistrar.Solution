// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc;
// using UniversityRegistrar.Models;
// using System.Collections.Generic;
// using System.Linq;

// namespace UniversityRegistrar.Controllers
// {
//   public class DepartmentsController : Controller
//   {
//     private readonly UniversityRegistrarContext _db;

//     public DepartmentsController(UniversityRegistrarContext db)
//     {
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       List<Department> model = _db.Departments.ToList();
//       return View(model);
//     }

//     public ActionResult Create()
//     {
//       return View();
//     }

//     [HttpPost]
//     public ActionResult Create(Department department)
//     {
//       _db.Departments.Add(department);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     public ActionResult Details(int id)
//     {
//       var thisDepartment = _db.Departments
//           .Include(department => department.JoinEntities)
//           .ThenInclude(join => join.Student)
//           .FirstOrDefault(department => department.DepartmentId == id);
//       return View(thisDepartment);
//     }
//     public ActionResult Edit(int id)
//     {
//       var thisCourse = _db.Courses.FirstOrDefault(department => department.DepartmentId == id);
//       ViewBag.StudentId = new SelectList(_db.Students, )
//       return View(thisCourse);
//     }

//     [HttpPost]
//     public ActionResult Edit(Course course)
//     {
//       _db.Entry(course).State = EntityState.Modified;
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     public ActionResult Delete(int id)
//     {
//       var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
//       return View(thisCourse);
//     }

//     [HttpPost, ActionName("Delete")]
//     public ActionResult DeleteConfirmed(int id)
//     {
//       var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
//       _db.Courses.Remove(thisCourse);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
//   }
// }