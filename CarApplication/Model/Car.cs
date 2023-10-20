using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication.Model
{
    public class Car
    {
        public int Id { get; set; }
        public String Make { get; set; }
        public String Color { get; set; }
        public String Petname { get; set; }
        public List<Car> Cars { get; set; }
        public Car()
        {
        }
        
        
    }
}



