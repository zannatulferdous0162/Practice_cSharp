using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Method_class_member
{

    class person
    {
        public string name;
        public int age;

        //default constractor
        public person()
        {
            name = "Shaheda";
            age = 28;
        }
        //perameter constractor
        public person(string n , int a)
        {
            name = n;
            age = a;
        }

        //Method for get and set the variable

        public void SetValue(string n,int a)
        {
            name = n;
            age = a;
        }

        //Method create for Display the value 
        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {name}, Age: {age}\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person("Zannat",26);//perameter constractor
           // p1.SetValue("Zannatul Ferdous Sheikh",27);
            p1.DisplayInfo();

            person p2 = new person("Sheikh",33);//perameter constractor
           // p2.SetValue("Rowshon Sheikh", 23);
            p2.DisplayInfo();

            //default constractor
            person p3 = new person();
            p3.DisplayInfo();
        }
    }
}
