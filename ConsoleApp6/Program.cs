using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace ConsoleApp6
{
    class Program
    {

        static void Check(List<Citizen> lciti, List<Robot> lrobo, List<Pet> lpet, string chek)
        {
/*            foreach (var robot in lrobo)
            {
                Regex rgx = new Regex($".*{chek}");
                if (rgx.IsMatch(robot.Id)) {
                    Console.WriteLine(robot.Id);
                }
            }*/

            foreach(var citi in lciti)
            {
                Regex rgx = new Regex($".*{chek}");
                if (rgx.IsMatch(citi.Date))
                {
                    Console.WriteLine(citi.Date);
                }
            }

            foreach (var pet in lpet)
            {
                Regex rgx = new Regex($".*{chek}");
                if (rgx.IsMatch(pet.Date))
                {
                    Console.WriteLine(pet.Date);
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
            List<Pet> lpet = new List<Pet>();
            do
            {
                first = Console.ReadLine();
                string[] second = first.Split(' ');

                if (second[0] == "Robot")
                {
                    Robot rob = new Robot(second[2], second[1]);
                    lrobo.Add(rob);
                }
                else
                if (second[0]== "Citizen")
                {
                    Citizen cit = new Citizen(second[3], second[1], int.Parse(second[2]), second[4]);
                    lciti.Add(cit);
                }
                else
                if (second[0] == "Pet")
                {
                    Pet pet = new Pet(second[1], second[2]);

                    lpet.Add(pet);
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

            Check(lciti,lrobo,lpet,chek);


        }
  
    }   

}
