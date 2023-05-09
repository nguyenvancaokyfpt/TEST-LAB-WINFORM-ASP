using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;
using TestLabLibrary.DataAccess.Student;

namespace TestLabLibrary.Repository
{
    public class StudentRepository : IStudentRepository
    {
        bool IStudentRepository.AddStudent(TlStudent student) => StudentDAO.Instance.AddStudent(student);

        int IStudentRepository.CountAll() => StudentDAO.Instance.CountAll();

        bool IStudentRepository.DeleteStudent(int id) => StudentDAO.Instance.DeleteStudent(id);
        TlStudent? IStudentRepository.GetStudent(int id) => StudentDAO.Instance.GetStudentById(id);
        TlStudent? IStudentRepository.GetStudent(string username) => StudentDAO.Instance.GetStudentByUsername(username);
        List<TlStudent> IStudentRepository.GetStudents() => StudentDAO.Instance.GetStudents();
        List<TlStudent> IStudentRepository.GetStudents(int offset, int limit, string search) => StudentDAO.Instance.GetStudents(offset, limit, search);
        bool IStudentRepository.Login(string username, string password) => StudentDAO.Instance.Login(username, password);
        bool IStudentRepository.UpdateStudent(TlStudent student) => StudentDAO.Instance.UpdateStudent(student);
    }
}
