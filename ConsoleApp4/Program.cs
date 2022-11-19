using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Write numbers");
            string nums = Console.ReadLine();
            Console.WriteLine("Write urls");
            string urls = Console.ReadLine();

            Smartpfone smartpfone = new Smartpfone(nums,urls);

            smartpfone.Do();
        }
    }
}
