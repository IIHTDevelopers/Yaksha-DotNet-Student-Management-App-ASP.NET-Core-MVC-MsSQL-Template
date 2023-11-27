using StudentManagementApp.DAL.Interface;
using StudentManagementApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManagementApp.DAL.Repository
{
    public class StudentManagementService : IStudentInterface
    {
        private IStudentRepository _repo;
        public StudentManagementService(IStudentRepository repo)
        {
            this._repo = repo;
        }

        public Student AddStudent(Student student)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Student DeleteStudent(int studentId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Student GetStudentById(int studentId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Student UpdateStudent(Student student)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}