using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Citizen : IPerson, IBirthable,IIdentifiable
    {
        public string Name { get; set; }
       public int Age { get; set; }
        public string Birthdate { get; set; }
        public string Id { get; set; }
        public Citizen(string name, int age, string id, string date)
        {
            Name = name;    
            Age = age;
            Id = id;
            Birthdate = date;
        }

    }
}
