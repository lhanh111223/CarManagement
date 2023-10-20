using CarApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication.Repository
{
    internal interface IAccountRepository
    {
        Account Login(string username, string password);
        void SetRole(string role);
    }
}
