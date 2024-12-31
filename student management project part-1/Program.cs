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
            set { _dateOfBirth = value; }
        }

        public string RollNo
        {
            get { return _rollNo; }
            set { _rollNo = value; }
        }

        /*Constractor*/
        public Student(string name,DateTime dateTime, string rollNo)
        {
            Name = name;
            DateOfBirth = dateTime;
            RollNo = rollNo;
        }

    }






    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
