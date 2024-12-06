using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_management_project
{

    public class Student
    {   //field declare
        private string _name;
        private DateTime _dateOfBirth;
        private string _rollNumber;


        //properties create(readable and writeable)
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
                    throw new ArgumentException("Date of birth can not be in the Future");
                }
                _dateOfBirth = value;
            }
        }
        public string RollNumber
        {
            get { return _rollNumber; }
            set { _rollNumber = value; }
        }

        //constractor
        public Student(string name, DateTime dateOfBirth, string rollNumber)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            RollNumber = rollNumber;
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            //object
            try
            {
                Student student1 = new Student("Zannat", new DateTime(1998, 05, 17), "IDB373");
                Student student2 = new Student("Asif", new DateTime(2025, 04, 19), "IDB374");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
