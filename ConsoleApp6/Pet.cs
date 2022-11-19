using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime;
namespace ConsoleApp6
{
    internal class Pet : Enterers
    {
        public string Date { get; set; }

        public Pet(string name,string date) : base()
        {
            Name = name;
            Date = date;


        }


    }
}
