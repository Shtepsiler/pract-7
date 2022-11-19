using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Citizen : Enterers, IBuyer
    {
        public int Age { get; set; }
        public string Date { get; set; }
        public Citizen() { }
        public Citizen(string id, string name, int age, string date) : base(id, name)
        {
            Age = age;

            Date = date;

        }

        int food = 10;
        public int Food { get { return food; } }
    public int BuyFood()
    {
        return food;
    }
    }


}



