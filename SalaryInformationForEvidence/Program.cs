using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SalaryInformationForEvidence
{
    public enum Designation
    {
        Director = 1,
        AssaistentDirector,
        GeneralManager,
        AssistantManager,
        Accountant,
        SeniorOfficer,
        Cashier,
        Others

    }
    public abstract class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public interface IOvertime
    {
        double CalculateOvertime(double basic, double hoursWorked);

    }

    public sealed class Employee : Person, IOvertime
    {
        public Designation EmployeeDesignation { get; set; }
        public double BasicSalary { get; set; }
        public double HouseRent => 0.4 * BasicSalary;
        public double MedicalAllowance { get; set; }
        public double Conveyance => 0.05 * BasicSalary;
        public double OvertimeHours { get; set; }
        public double GrossSalary => BasicSalary + HouseRent + MedicalAllowance + Conveyance + CalculateOvertime(BasicSalary, OvertimeHours);
        public List<string> Roles { get; set; } = new List<string>();


        public double CalculateOvertime(double basic, double hoursWorked)
        {
            double hourlyRate = basic / 208;
            double OverTimePayment = 2 * hourlyRate * hoursWorked;
            return Math.Round(OverTimePayment, 2);

        }
    }






    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee ID: ");
            int id;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out id))
                {
                    break;
                }
                else
                {

                    Console.WriteLine("Invalid ID format!!!! Please enter a valid numeric ID.");
                    Console.Write("Enter Employee ID: ");
                }
            }


            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("The Available Designations Are:");
            Console.WriteLine("1: Director");
            Console.WriteLine("2: Assistant Director");
            Console.WriteLine("3: General Manager");
            Console.WriteLine("4: Assistant Manager");
            Console.WriteLine("5: Accountant");
            Console.WriteLine("6: Senior Officer");
            Console.WriteLine("7: Cashier");
            Console.WriteLine("8: Others");
            Console.WriteLine();


            Designation designation;
            while (true)
            {
                Console.Write("Please Insert Designation Number (1-8): ");
                if(int.TryParse(Console.ReadLine(),out int designationNumber) &&  designationNumber >= 1  && designationNumber <= 8)
                {
                    designation = (Designation)designationNumber;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!!!!!! Please enter a valid number between 1 and 8.");
                }
            }
            Console.Write("Enter Basic Salary:");
            double basicSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Medical Allowance:");
            double medicalAllowance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Overtime Hours:");
            double overtimeHours = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Roles Using (,) and  Press Enter to Finish \n Enter your Roles : ");

            string rolesInput = Console.ReadLine();
            List<string> roles = new List<string>(rolesInput.Split(','));

            //Create Employee Object
            Employee employee = new Employee
            {
                Name = name,
                ID = id,
                EmployeeDesignation = designation,
                BasicSalary = basicSalary,
                MedicalAllowance = medicalAllowance,
                OvertimeHours = overtimeHours,
                Roles = roles
            };

            Console.WriteLine();
            Console.WriteLine("======================Salary Details========================");
            Console.WriteLine($"Name                    : {employee.Name}");
            Console.WriteLine($"ID                      : {employee.ID}");
            Console.WriteLine($"Designation             : {employee.EmployeeDesignation}");
            Console.WriteLine($"Basic Salary            : {employee.BasicSalary}");
            Console.WriteLine($"House Rent              : {employee.HouseRent}");
            Console.WriteLine($"Medical Allowance       : {employee.MedicalAllowance}");
            Console.WriteLine($"Conveyance              : {employee.Conveyance}");
            Console.WriteLine($"Overtime Payment        : {employee.CalculateOvertime(employee.BasicSalary, employee.OvertimeHours)}");
            Console.WriteLine($"Gross Salary            : {employee.GrossSalary}");
            Console.WriteLine($"Roles Of Employee       : {(string.Join(", ", employee.Roles).Trim())}");
            Console.ReadKey();



        }
    }
}
