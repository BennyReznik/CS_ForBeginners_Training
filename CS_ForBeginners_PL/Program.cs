using System;
using System.Collections.Generic;
using CS_ForBeginners_BL.Managers;
using CS_ForBeginners_BL.Models;
using CS_ForBeginners_Pl;
using Microsoft.Extensions.DependencyInjection;

namespace CS_ForBeginners_PL
{
    internal class Program
    {
        /// <summary>
        /// This is the entry point to our program
        /// it is also called Presentation Layer
        /// This projects output is an executable file that is used to run the application
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            DependencyInjectionPl.AddDependencies();

            var serviceProvider = DependencyInjectionPl.ServiceCollection.BuildServiceProvider();
            var personManager = serviceProvider.GetService<IPersonManager>();

            var action = 0;
            while (action != 9)
            {
                Console.WriteLine("Please select what action would you like to execute");

                Console.WriteLine("1: Print people list");
                Console.WriteLine("2: Add person");
                Console.WriteLine("3: Get person");
                Console.WriteLine("4: Update person");
                Console.WriteLine("5: Delete person");
                Console.WriteLine("9: Exit");

                action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Selected {action}");
                Console.WriteLine();

                switch (action)
                {
                    case 1:
                        {
                            // Get all people
                            var people = personManager.GetAll();
                            PrintListOfPeople(people);
                            break;
                        }
                    case 2:
                        {
                            // Add person
                            Console.WriteLine("Enter Id");
                            var id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            var name = Console.ReadLine();
                            Console.WriteLine("Enter Age");
                            var age = Convert.ToInt32(Console.ReadLine());
                            var person = new PersonModel(id, name, age);
                            personManager.AddPerson(person);
                            Console.WriteLine("Person Added");
                            break;
                        }
                    case 3:
                        {
                            // Get person
                            Console.WriteLine("Person Id");
                            var id = Convert.ToInt32(Console.ReadLine());
                            var person = personManager.GetById(id);
                            Console.WriteLine(person.ToString());
                            break;
                        }
                    case 4:
                        {
                            // Update person
                            Console.WriteLine("Enter Id");
                            var id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            var name = Console.ReadLine();
                            Console.WriteLine("Enter Age");
                            var age = Convert.ToInt32(Console.ReadLine());
                            var person = new PersonModel(id, name, age);
                            personManager.UpdatePerson(person);
                            Console.WriteLine("Person Updated");
                            break;
                        }
                    case 5:
                        {
                            // Delete person
                            Console.WriteLine("Person Id");
                            var id = Convert.ToInt32(Console.ReadLine());
                            personManager.DeletePerson(id);
                            Console.WriteLine("Person Deleted");
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid action");
                        break;
                }
            }
        }

        private static void PrintListOfPeople(IEnumerable<PersonModel> people)
        {
            var number = 1;
            foreach (var person in people)
            {
                Console.WriteLine($"Person {number}");
                Console.WriteLine(person.ToString());
                Console.WriteLine();
                number++;
            }
        }
    }
}
