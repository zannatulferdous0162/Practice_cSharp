using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_class_member
{

    class person
    {
        public string name;
        public int age;

        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {name}, Age: {age}\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            p1.name = "Zannatul Ferdous Sheikh";
            p1.age = 33;
            p1.DisplayInfo();

            person p2 = new person();
            p2.name = "Rowshon Sheikh";
            p2.age = 21;
            p2.DisplayInfo();


        }
    }
}
