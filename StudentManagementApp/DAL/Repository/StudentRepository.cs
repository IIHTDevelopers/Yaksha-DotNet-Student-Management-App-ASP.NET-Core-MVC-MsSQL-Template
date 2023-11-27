using StudentManagementApp.DAL.Interface;
using StudentManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StudentManagementApp.DAL.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private StudentDbContext _context;
        public StudentRepository(StudentDbContext Context)
        {
            this._context = Context;
        }
      
        public Student GetStudentById(int studentId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Student AddStudent(Student student)
        {
            //write your code here
            throw new NotImplementedException();
        }


        public Student UpdateStudent(Student updatedStudent)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Student DeleteStudent(int studentId)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
