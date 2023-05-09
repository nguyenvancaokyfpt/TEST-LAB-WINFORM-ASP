using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.Repository
{
    public interface IAdminRepository
    {
        TlAdmin Login(string username, string password);
    }
}
