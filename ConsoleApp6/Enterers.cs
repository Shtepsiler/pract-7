using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    abstract class Enterers
    {
        string id;
        public  string Id { get { return id; } }


        string name;
        public string Name { get { return name; } set { name = value; } }

        public Enterers() { }
        public Enterers(string ib,string nam ) { id = ib; Name = nam; }
    }
}
