using System;
using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 0; i < 2; i++)
            {
                var car = new Ferrari();
                Console.WriteLine("name: ");
                car.Name = Console.ReadLine();
                Console.WriteLine(car.Masage());
            }
        }
    }
}
