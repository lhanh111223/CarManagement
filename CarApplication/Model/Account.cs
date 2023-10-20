using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication.Model
{
    public class Account
    {
        public string username {  get; set; }
        public string password { get; set; }
        public Account() {
            this.username = "admin";
            this.password = "admin";
        }
    }
}
