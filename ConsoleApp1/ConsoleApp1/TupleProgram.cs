using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TupleProgram
    {
        public (string FirstName, string LastName, int Age) person;
        public void CreatePerson()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                person = (firstName, lastName, age);
                Console.WriteLine("Person created successfully.");
            }
            else
            {
                Console.WriteLine("Invalid age input.");
            }
        }

        public void ReadPerson()
        {
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine($"Age: {person.Age}");
        }

        public void UpdatePerson()
        {
            if (person == default)
            {
                Console.WriteLine("No person exists. Create one first.");
                return;
            }

            Console.WriteLine("Choose a field to update:");
            Console.WriteLine("1. First Name");
            Console.WriteLine("2. Last Name");
            Console.WriteLine("3. Age");
            Console.Write("Select a field to update (1-3): ");

            if (int.TryParse(Console.ReadLine(), out int fieldChoice))
            {
                switch (fieldChoice)
                {
                    case 1:
                        Console.Write("Enter new first name: ");
                        person = (Console.ReadLine(), person.LastName, person.Age);
                        break;
                    case 2:
                        Console.Write("Enter new last name: ");
                        person = (person.FirstName, Console.ReadLine(), person.Age);
                        break;
                    case 3:
                        Console.Write("Enter new age: ");
                        if (int.TryParse(Console.ReadLine(), out int age))
                        {
                            person = (person.FirstName, person.LastName, age);
                        }
                        else
                        {
                            Console.WriteLine("Invalid age input.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid field choice.");
                        break;
                }
                Console.WriteLine("Field updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        public void DeleteField()
        {
            if (person == default)
            {
                Console.WriteLine("No person exists. Create one first.");
                return;
            }

            Console.WriteLine("Choose a field to delete:");
            Console.WriteLine("1. First Name");
            Console.WriteLine("2. Last Name");
            Console.WriteLine("3. Age");
            Console.Write("Select a field to delete (1-3): ");

            if (int.TryParse(Console.ReadLine(), out int fieldChoice))
            {
                switch (fieldChoice)
                {
                    case 1:
                        person = (default, person.LastName, person.Age);
                        break;
                    case 2:
                        person = (person.FirstName, default, person.Age);
                        break;
                    case 3:
                        person = (person.FirstName, person.LastName, default);
                        break;
                    default:
                        Console.WriteLine("Invalid field choice.");
                        break;
                }
                Console.WriteLine("Field deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

    }
}
