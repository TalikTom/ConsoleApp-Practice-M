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
        public static List<PersonModel> people = new List<PersonModel>();

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

    }
}
