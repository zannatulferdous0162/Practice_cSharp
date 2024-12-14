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
        public int Id { get; set; }
    }
    sealed class Employee
    {
        public string Designation { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal HouseRent { get; set; }
        public decimal MedicalBill { get; set; }
        public decimal ConveyanceFee { get; set; }
        public decimal Overtime { get; set; }
        public decimal GrossSalary { get; set; }
        public List<string> RolesPlay { get; set; }

        public Employee()
        {
            RolesPlay = new List<string>();
        }

        


    }


}
