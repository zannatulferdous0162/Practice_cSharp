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

        //Auto implimented properties

        //public string name
        //{
        //    get { return name;}
        //    set { value = name;}
        //}

        //public int age
        //{
        //    get { return age; }
        //    set { value = age; }    
           
        //}

        //
        public string Name
        {
            get { return name; }
            set { if (value.Length >= 2)
                {
                    name = value;
                }                   
                }
        }
    
        public int Age
        {
            get { return age; }
            set {if(value > 0)
                {
                    age = value;
                }                
                }
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
