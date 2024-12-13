using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 6;
            try
            {
                b = 100 / a;
                checked
                {
                    //int value = int.MaxValue;
                    //int value = int.MaxValue + 1;
                    int value = int.MaxValue + int.Parse("1");
                    Console.WriteLine(value);
                }
            }
            catch (OverflowException ofe)
            {
                Console.WriteLine("Response from Overflow Exception Block");
            }
            catch (DivideByZeroException dze)
            {
                Console.WriteLine("Response from Divide By Zero Exception Block");
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine("Response from Invalid Operation Exception Block");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("Response from Argument Exception Block");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Found");
            }

            finally
            {
                Console.WriteLine("Response from finally Block");
            }
        }
    }
}
