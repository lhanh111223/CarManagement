using CarApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public static string role { get; set; } = "customer";
        public Account Login(string username, string password)
        {
            if(username == "admin" && password == "admin")
            {

            }
            return null;
        }
        public void SetRole(string role)
        {

        }
    }
}
