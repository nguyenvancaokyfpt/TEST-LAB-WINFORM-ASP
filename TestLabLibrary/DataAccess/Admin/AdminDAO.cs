using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.DataAccess.Admin
{
    public class AdminDAO
    {
        private static AdminDAO? instance = null;
        private static readonly object padlock = new object();

        public static AdminDAO Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new AdminDAO();
                    }
                    return instance;
                }
            }
        }

        public TlAdmin? Login(string username, string password)
        {
            TlAdmin? admin = null;
            try
            {
                using (var db = new TestLabContext())
                {
                    admin = db.TlAdmins.Where(a => a.Username == username && a.Password == password).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return admin;
        }
    }
}
