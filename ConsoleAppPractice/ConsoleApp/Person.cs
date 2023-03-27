using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Person
    {
        public static List<PersonModel> people = new List<PersonModel>()
        {
             new PersonModel { FirstName = "Arsen", LastName = "Dedic", DOB = new DateTime(1990, 1, 1), Gender = "male"},
               new PersonModel { FirstName = "Kico", LastName = "Slabinac", DOB = new DateTime(1988, 12, 5), Gender = "male"},
               new PersonModel { FirstName = "Ibrica", LastName = "Jusic", DOB = new DateTime(2001, 6, 5), Gender = "male"},
               new PersonModel { FirstName = "Toma", LastName = "Zdravkovic", DOB = new DateTime(1999, 3, 3), Gender = "male"},
               new PersonModel { FirstName = "Josipa", LastName = "Lisac", DOB = new DateTime(1955, 1, 3), Gender = "female"},
        };

        public static void AddPeople()
        {
            string answer;

            do
            {
                PersonModel newPerson = new PersonModel();

                Console.WriteLine("Enter first name:");
                newPerson.FirstName = Console.ReadLine();

                Console.WriteLine("Enter last name:");
                newPerson.LastName = Console.ReadLine();

                Console.WriteLine("Enter date of birth (format: DD/MM/YYYY):");
                string dobString = Console.ReadLine();
                newPerson.DOB = DateTime.ParseExact(dobString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Console.WriteLine("Enter gender:");
                newPerson.Gender = Console.ReadLine();

                people.Add(newPerson);

                Console.WriteLine("Do you want to add another person? (Y/N)");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "y");
        }

        public static void ViewPeople()
        {
            foreach (PersonModel person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }

            Console.WriteLine("These are first and last names of the people in the list\n");
            Console.WriteLine("Press enter to return to main menu\n");
            Console.ReadLine();
        }


        public static void GetOldestPerson()
        {
            PersonModel oldestPerson = null;
            DateTime oldestDOB = DateTime.MaxValue;

            foreach (var person in people)
            {
                if (person.DOB < oldestDOB)
                {
                    oldestDOB = person.DOB;
                    oldestPerson = person;
                }
            }

            Console.WriteLine($"The oldest person is {oldestPerson.FirstName} {oldestPerson.LastName} - {oldestPerson.DOB}");
           
            Console.WriteLine("Press enter to return to main menu\n");
            Console.ReadLine();
        }

        public static void GetYoungestPerson()
        {
            PersonModel youngestPerson = null;
            DateTime youngestDOB = DateTime.MinValue;

            foreach (var person in people)
            {
                if (person.DOB > youngestDOB)
                {
                    youngestDOB = person.DOB;
                    youngestPerson = person;
                }
            }

            Console.WriteLine($"The youngest person is {youngestPerson.FirstName} {youngestPerson.LastName} - {youngestPerson.DOB}");
         
            Console.WriteLine("Press enter to return to main menu\n");
            Console.ReadLine();
        }


        public static int CountGender(string gender)
        {
            int count = people.Count(p => p.Gender == gender);
            Console.WriteLine($"There are {count} {((gender == "male") ? "males" : "females")} in the list.");

            return count;
        }

    }
}
