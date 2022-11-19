using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Citizen : Enterers
    {
        public int Age { get; set; }
        public string Date { get; set; }  
        public Citizen(string id, string name, int age, string date ) : base(id,name)
        {
            Age = age;

            Date = date;

        }
    }
}
