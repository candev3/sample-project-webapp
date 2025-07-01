using Microsoft.AspNetCore.Mvc;
using StudentManagementApp.Models;
using StudentManagementApp.Services;

namespace StudentManagementApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;
        
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        
        // GET: Students
        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents();
            return View(students);
        }
        
        // GET: Students/Details/5
        public IActionResult Details(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        
        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }
        
        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.AddStudent(student);
                TempData["SuccessMessage"] = "เพิ่มข้อมูลนักเรียนเรียบร้อยแล้ว";
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
        
        // GET: Students/Edit/5
        public IActionResult Edit(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        
        // POST: Students/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }
            
            if (ModelState.IsValid)
            {
                _studentService.UpdateStudent(student);
                TempData["SuccessMessage"] = "แก้ไขข้อมูลนักเรียนเรียบร้อยแล้ว";
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
        
        // GET: Students/Delete/5
        public IActionResult Delete(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        
        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _studentService.DeleteStudent(id);
            TempData["SuccessMessage"] = "ลบข้อมูลนักเรียนเรียบร้อยแล้ว";
            return RedirectToAction(nameof(Index));
        }
    }
}
