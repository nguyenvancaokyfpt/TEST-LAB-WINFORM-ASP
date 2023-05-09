using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;
using TestLabLibrary.DataAccess.Admin;

namespace TestLabLibrary.Repository
{
    public class AdminRepository : IAdminRepository
    {
        public TlAdmin Login(string username, string password)
        {
            try
            {
                var admin = AdminDAO.Instance.Login(username, password);
                return admin;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
