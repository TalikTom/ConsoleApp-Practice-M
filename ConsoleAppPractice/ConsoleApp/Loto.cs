using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Loto
    {
        public static void GenerateLoto(int min, int max)
        {

            while (true)
            {

                List<int> list = new List<int>();
                Random rnd = new Random();
                int index = 0;

                while (true)
                {
                    int randomNum = rnd.Next(min, max);
                    list.Add(randomNum);
                    if (index == (min-1))
                    {
                        break;
                    }
                    index++;
                }

                Console.WriteLine($"Your lucky {min} numbers are: ");

                foreach (int i in list)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine($"Do you want to generate new {min} lucky numbers (they won't be as lucky as the first set)? (Y/N)");



                string answer = Console.ReadLine();

                if (answer.ToLower() == "n")
                {
                    break;
                }

                while (answer.ToLower() != "y" && answer.ToLower() != "n")
                {
                    Console.WriteLine("Invalid input! Please enter Y or N\n");
                    answer = Console.ReadLine();
                }

            }




        }
    }
}
