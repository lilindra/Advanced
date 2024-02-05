/*
5
Niki 33
Yord 88
Teo 22
Lily 44
Stan 11
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            
            
            int n = int.Parse(Console.ReadLine());

            List<Person> list = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                string name = command.Split()[0];
                int age = int.Parse(command.Split()[1]);

                Person person = new Person(name,age);
                list.Add(person);

            }

            List<Person> sortedNames = list.OrderBy(person => person.Name).ToList();


            

            foreach (var person in sortedNames)
            {

                if (person.Age > 30)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
        }

    }
}
