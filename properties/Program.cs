using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
     class Person
    {
        public string name;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }

    class Test
    {
        public static void Main(string[]args )
        {
            Person p1 = new Person();
            p1.name = "Zannat";
            p1.Age = 22;
            Console.WriteLine($"Name : {p1.name}, Age : {p1.Age}");
            //Diffrence public and private using properties
        }
    }

}
