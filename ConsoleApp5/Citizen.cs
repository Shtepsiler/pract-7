using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Citizen : Enterers
    {
        public int Age { get; set; }
        public Citizen(string id, string name, int age) : base(id,name)
        {
            Age = age;
        }
    }
}
