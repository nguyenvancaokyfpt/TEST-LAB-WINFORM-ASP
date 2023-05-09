using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.Repository
{
    public interface IStudentRepository
    {
        List<TlStudent> GetStudents();
        List<TlStudent> GetStudents(int offset = 0, int limit = 10, string search = "");
        TlStudent? GetStudent(int id);
        TlStudent? GetStudent(string username);
        bool AddStudent(TlStudent student);
        bool UpdateStudent(TlStudent student);
        bool DeleteStudent(int id);
        int CountAll();
        bool Login(string username, string password);
    }
}
