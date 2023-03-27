using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Average
    {
        public static void CalculateGradeAverage()
        {

            while (true)
            {
                List<int> grades = new List<int>();

                int grade;
                do
                {
                    grade = Helper.GetIntFromConsole("Enter a grade or 0 to exit: ");

                    if (grade != 0)
                    {
                        grades.Add(grade);
                    }

                } while (grade != 0);


                double avg = Queryable.Average(grades.AsQueryable());

                Console.WriteLine("Average grade is = " + Math.Round(avg, 2));

                Console.WriteLine("Do you want to calculate another average of grades? (Y/N)");

                

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
