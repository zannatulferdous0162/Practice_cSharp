using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_management_project_part_1
{

    public class Student
    {
        private string _name;
        private DateTime _dateOfBirth;
        private string _rollNo;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Date Time can not be future");
                }
                _dateOfBirth = value;
            }
        }

        public string RollNo
        {
            get { return _rollNo; }
            set { _rollNo = value; }
        }

        /*Constractor*/
        public Student(string name, DateTime dateTime, string rollNo)
        {
            Name = name;
            DateOfBirth = dateTime;
            RollNo = rollNo;
        }

    }






    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Student student1 = new Student("Zannat", new DateTime(1990, 3, 30), "Diploma162");
                Student student2 = new Student("Zannat Sheikh", new DateTime(2023, 3, 30), "Diploma163");

                /*Display student detail*/
                Console.WriteLine($"Show student details");
                Console.WriteLine("___________________");
                Console.WriteLine($"Name : {student1.Name},Date of Birth :{student1.DateOfBirth},Roll No : {student1.RollNo}");
                Console.WriteLine("___________________");
                Console.WriteLine($"Name : {student2.Name},Date of Birth :{student2.DateOfBirth},Roll No : {student2.RollNo}");
            }
           
        }
    }
}
