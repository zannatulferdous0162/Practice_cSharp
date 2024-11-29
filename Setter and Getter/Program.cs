using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setter_and_Getter
{
    class person
    {
        public String name; // Readable and writeable
        private int age; //not readable and not writeable

        public void SetAge(int a)//writeablw
        {
            age = a;
        }
        public int GetAge()
        {
            return age;
        }

          class Test
        {
            public static  void Main(string[] args)
            {
                person p1 = new person();
                p1.name = "Zannat";
                p1.SetAge(11);//writeable
                Console.WriteLine($"Name : {p1.name}, Age: {p1.GetAge()}\n");


            }
        }
    }
}
