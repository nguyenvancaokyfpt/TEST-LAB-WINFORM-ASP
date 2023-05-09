using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.Repository
{
    public class Repository : IRepository
    {
        AdminRepository IRepository.AdminRepository => new AdminRepository();

        StudentRepository IRepository.StudentRepository => new StudentRepository();

        QuestionRepository IRepository.QuestionRepository => new QuestionRepository();

        PaperRepository IRepository.PaperRepository => new PaperRepository();

        TlAdmin IRepository.Admin { get; set; }
    }
}
