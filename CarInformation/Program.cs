using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInformation
{

    public enum VehicleType
    { 
        Car,
        Motorcycle
    }
    public interface IInteriorDesign
    {
        List<string> InteriorDesign { get; set; }   
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
