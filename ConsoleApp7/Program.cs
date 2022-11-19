using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace ConsoleApp7
{
    class Program
    {


        static void BuyAllFood(List<Citizen> lcit, List<Rebel> lreb)
        {
            int count = 0;

            Console.WriteLine("write people");
            string first;
            do
            {
                first = Console.ReadLine();

                foreach (Citizen citizen in lcit)
                {
                    if(citizen.Name == first)
                    {
                        count=count+citizen.Food;
                    }
                }
                foreach(Rebel rebel in lreb)
                {
                    if(rebel.Name == first)
                    {
                        count =  count+rebel.Food;
                    }
                }




            } while (first != "End");



            Console.WriteLine(count);

        }








        static void Main()
        {
            Console.WriteLine("write number of enterers");
            int n = int.Parse(Console.ReadLine());
            string first;
            List<Citizen> lciti = new List<Citizen>();
            List<Rebel> lreb = new List<Rebel>();
            for(int i = 0; i < n; i++)
            {
                first = Console.ReadLine();
                string[] second = first.Split(' ');

               
                if (second.Length == 4)
                {
                    Citizen cit = new Citizen(second[2], second[0], int.Parse(second[1]), second[3]);
                    lciti.Add(cit);
                }
                else 
                if(second.Length == 3)  
                 {
                    Rebel rebel = new Rebel(second[0], int.Parse(second[1]), second[2]);
                    lreb.Add(rebel);
                }          
                else
                {
                    Console.WriteLine("Wrong enterer");

                }
            }


            BuyAllFood(lciti, lreb);






        }
  
    }   

}
