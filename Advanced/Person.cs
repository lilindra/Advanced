using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        // полета(характеристики) - име и възраст
        private string name;
        private int age;

        //конструктор - когато искаме да създадем обекти от даден клас
        /* public Person()
         {
             Name = "No name";
             Age = 1;
         }

         public Person(int age)
         {
             Name = "No name";
             Age = age;
         } */


        //конструкто с параметри
        public Person(string name, int age)
        {
            //нов празен обект
            Name = name;
            Age = age;
        }

        //методи за достъп до полето
        public string Name
        {
            get { return name; } // достъп до полето
            set { name = value; } // задавам стойност на полето
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
