using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {

        // 1. Add Fields
        private string name;
        private int age;

        // 2. Add Constructor
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // 3. Add Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // 4. Add Methods

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
            this.Name,
            this.Age));
            return stringBuilder.ToString();
        }


    }
}
