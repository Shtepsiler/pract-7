using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Rebel : Citizen
    {
        string group;

         public string Group { get; set; }
        public Rebel(string name, int age, string gr ) : base()
        {
            Name = name;
            Age = age;
            Group = gr;
        }
        int food = 5;
        public int Food { get { return food;} }

        public int BuyFood()
        {
            return food;
        }




    }
}
