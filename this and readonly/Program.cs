using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_and_readonly
{

    public class Student
    {
        //readonly diye 2 vabe kora jay 1.declare 2.constractor diye
        //public readonly int age = 30;// declare
        public readonly int age;

        public Student (int age)//constractor --> value pass hobe object theke
        {
            this.age = age;
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student() { age = 30};//value evabeo assain kora jay
            Student s1 = new Student(30);
            //s1.age = 22;
            Console.WriteLine($"Age : {s1.age}");
        }
    }
}
