using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("write name");
            string name = Console.ReadLine();
            Console.WriteLine("write age");
            int age = int.Parse(Console.ReadLine()); 
            IPerson person = new Citizen(name, age); 
            Console.WriteLine(person.Name); 
            Console.WriteLine(person.Age);
        }
    }
}
