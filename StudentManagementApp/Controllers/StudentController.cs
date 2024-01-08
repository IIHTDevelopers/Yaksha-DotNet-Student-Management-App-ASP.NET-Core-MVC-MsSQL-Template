using Microsoft.AspNetCore.Mvc;
using StudentManagementApp.DAL.Interface;
using StudentManagementApp.Models;

namespace StudentManagementApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentInterface _studentRepository;

        public StudentController(IStudentInterface studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // GET: /Student/Index
        public IActionResult Index()
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Student/Details/{id}
        public IActionResult Details(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Student/Create
        public IActionResult Create()
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Student/Edit/{id}
        public IActionResult Edit(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Student/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Student updatedStudent)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Student/Delete/{id}
        public IActionResult Delete(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Student/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
