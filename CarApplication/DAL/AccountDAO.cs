using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication.DAL
{
    class AccountDAO
    {
        private static string role = "customer";
        public AccountDAO() { }
        public bool Login(string username, string password)
        {
            if(username == "admin" &&  password == "admin")
            {
                role = "admin";
                return true;
            }
            return false;
        }
        public void Logout()
        {
            role = "customer";
        }
        public string GetRole()
        {
            return role;
        }
        public void SetRole(string  role)
        {
            //this.role = role;
        }
        
    }
}
