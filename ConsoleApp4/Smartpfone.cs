using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp4
{
    internal class Smartpfone: Call,Browse
    {
        
        List<string> Numners = new List<string>(); 
        List<string> UrLs = new List<string>();


        public Smartpfone() { }

        public Smartpfone(string nums, string urls)
        {
            string[] Snums = nums.Split(" ");
            string[] Surls = urls.Split(" ");

            foreach (string s in Snums)
            {
                Numners.Add(s);
            }

            foreach(string s in Surls)
            {
                UrLs.Add(s);
            }
        }
         public void BrowseMcasage(List<string> urls)
        {
            Regex rgx = new Regex("[0-9]");

            foreach (string s in urls)
            {
                try
                {
                    if (rgx.IsMatch(s))
                    {                
                    throw new ArgumentException("Invalid URL!");
                    }
                    else
                    {                  
                    Console.WriteLine($"Browsing: {s}");
                    }
                }
                catch(ArgumentException ex) { 
                
                    Console.WriteLine(ex.Message);
                }
            }
        }   
        public void CallMasage(List<string> numbers)
        {
            Regex rgx = new Regex("[a-z]|[A-Z]");

            foreach (string n in numbers)
            {
                try
                {
                    if (rgx.IsMatch(n))
                    { 
                        throw new ArgumentException("Invalid number!");
                        
                    }
                    else
                    { 
                Console.WriteLine($"Calling... {n}");
                    }
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
}

        public void Do()
        {   
            CallMasage(Numners);

            BrowseMcasage(UrLs);
        }






    }
}
