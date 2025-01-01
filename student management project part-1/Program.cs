using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_management_project_part_1
{

    public class Student
    {

        public string Name
        {
            get;
            private set; //only constractor diye set kora jabe
        }

        public DateTime DateOfBirth
        {
            get;
            private set; //only constractor diye set kora jabe
        }
        public string RollNo
        {
            get;
            private set; //only constractor diye set kora jabe
        }

        /*Constractor*/
        public Student(string name, DateTime dateOfBirth, string rollNo)
        {

            validateInput(name,dateOfBirth,rollNo);
            Name = name;
            DateOfBirth = dateOfBirth;
            RollNo = rollNo;
        }
        /*Method*/
        private static void validateInput(string name, DateTime dateOfBirth, string rollNo)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name can not be null or empty");
            }
            if (dateOfBirth > DateTime.Now)
            {
                throw new ArgumentException("Date Time can not be future");
            }
            if (string.IsNullOrEmpty(rollNo))
            {
                throw new ArgumentException("Roll Number can not be null or empty");
            }
            if (dateOfBirth == default)
            {
                throw new ArgumentException("Date Time can not be future");
            }

        }
        /*Method*/
        private int calculateAge()
        {
            int age = DateTime.Now.Year - DateOfBirth.Year;
            return DateTime.Now < DateOfBirth.AddYears(age) ?
            
                //if the birthday has not occurred yet, decrement by the age 1
                age-1 : age;
            
          
        }
        public void showStudentInfo()
        {
            Console.WriteLine($"Show student details");
            Console.WriteLine("___________________");
            Console.WriteLine($"Name : {Name},Date of Birth :{DateOfBirth.ToShortDateString()},Roll No : {RollNo},Age :{Age}");
        }
        //Property
        public int Age => calculateAge(); //lamda expression
        

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
                student1.showStudentInfo();
                Console.WriteLine("___________________");
                student2.showStudentInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
