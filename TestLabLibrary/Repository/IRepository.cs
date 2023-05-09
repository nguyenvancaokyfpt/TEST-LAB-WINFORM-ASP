using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.Repository
{
    public interface IRepository
    {
        public AdminRepository AdminRepository { get; }
        public StudentRepository StudentRepository { get; }
        public QuestionRepository QuestionRepository { get; }
        public PaperRepository PaperRepository { get; }

        public TlAdmin Admin { get; set; }

    }
}
