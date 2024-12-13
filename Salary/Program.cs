using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary

{

    abstract class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }

    sealed class Employee : Person
    {
        public string Designation { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal HouseRent { get; set; }
        public decimal MedicalBill { get; set; }
        public decimal ConveyanceFee { get; set; }
        public decimal OvertimeHours { get; set; }
        public decimal OvertimeFee { get; set; }
        public decimal GrossSalary { get; set; }
        public List<string> Roles { get; set; }

        public Employee()
        {
            Roles = new List<string>();
        }

        public void CalculateSalary()
        {
            HouseRent = Math.Round(BasicSalary * 0.40m, 2);
            ConveyanceFee = BasicSalary * 0.05m;
            OvertimeFee = Math.Round((BasicSalary / 208) * 2 * OvertimeHours, 2);
            GrossSalary = Math.Round(BasicSalary + HouseRent + MedicalBill + ConveyanceFee + OvertimeFee, 2);
        }

        public void DisplaySalaryDetails()
        {
            Console.WriteLine("================================OUTPUT================================");
            Console.WriteLine($"Name                : {Name}");
            Console.WriteLine($"ID                  : {ID}");
            Console.WriteLine($"Designation         : {Designation}");
            Console.WriteLine($"Basic Salary        : {BasicSalary}");
            Console.WriteLine($"House Rent          : {HouseRent}");
            Console.WriteLine($"Medical Bill        : {MedicalBill}");
            Console.WriteLine($"Conveyance Fee      : {ConveyanceFee}");
            Console.WriteLine($"Total Overtime Fee  : {OvertimeFee}");
            Console.WriteLine($"Gross Salary        : {GrossSalary}");
            Console.WriteLine($"Your Roles in the Institution are : {string.Join(", ", Roles)}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Please Enter Your Name: ");
            employee.Name = Console.ReadLine();

            Console.Write("Please Enter Your ID: ");
            employee.ID = int.Parse(Console.ReadLine());

            Console.WriteLine("The Available Designations Are");
            string[] designationsArray = { "1: Director", "2: Assistant Director", "3: General Manager", "4: Assistant Manager", "5: Senior Officer", "6: Cashier", "7: Others" };
            foreach (string i in designationsArray)
            {
                Console.WriteLine(i);
            }

            int designationNumber;
            while (true)
            {
                Console.Write("Please Insert Your Designation Number: ");
                if (int.TryParse(Console.ReadLine(), out designationNumber) && designationNumber >= 1 && designationNumber <= 8)
                {
                    employee.Designation = designationsArray[designationNumber - 1];
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!!! Please enter a number 1 to 8.");
                }

            }
            Console.Write("Enter Your Basic Salary: ");
            employee.BasicSalary = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Your Medical Bill: ");
            employee.MedicalBill = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Your Overtime Hours: ");
            employee.OvertimeHours = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Your Roles Using (,) and Press Enter to Finish\nEnter Your Roles: ");
            string rolesInput = Console.ReadLine();
            employee.Roles.AddRange(rolesInput.Split(','));

            employee.CalculateSalary();
            employee.DisplaySalaryDetails();

            Console.ReadLine();

        }
    }

 }
