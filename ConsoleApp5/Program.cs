using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace ConsoleApp5
{
    class Program
    {

        static void Check(List<Citizen> lciti, List<Robot> lrobo, string chek)
        {
            foreach (var robot in lrobo)
            {
                Regex rgx = new Regex($".*{chek}");
                if (rgx.IsMatch(robot.Id)) {
                    Console.WriteLine(robot.Id);
                }
            }

            foreach(var citi in lciti)
            {
                Regex rgx = new Regex($".*{chek}");
                if (rgx.IsMatch(citi.Id))
                {
                    Console.WriteLine(citi.Id);
                }
            }
        }



        static void Main()
        {
            Console.WriteLine("write enterers");
            string first;
           // string[] second;
            List<Citizen> lciti = new List<Citizen>();
            List<Robot> lrobo = new List<Robot>();
            do
            {
                first = Console.ReadLine();
                string[] second = first.Split(' ');

                if (second.Length == 2)
                {
                    Robot rob = new Robot(second[1], second[0]);
                    lrobo.Add(rob);
                }
                else
                if (second.Length == 3)
                {
                    Citizen cit = new Citizen(second[2], second[0], int.Parse(second[1]));
                    lciti.Add(cit);
                }
                else
                {
                    if (second[0] != "End")
                    {
                        Console.WriteLine("Wrong enterer");
                    }
                }

            }while (first != "End");

            Console.WriteLine("write number of the offender");
            
            string chek=Console.ReadLine();

            Check(lciti,lrobo,chek);


        }
  
    }   

}
