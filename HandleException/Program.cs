using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
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
            catch (OverflowException)
            {
                Console.WriteLine("Response from Overflow Exception Block");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Response from Divide By Zero Exception Block");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Response from Invalid Operation Exception Block");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Response from Argument Exception Block");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Found {ex.Message}");
            }

            finally
            {
                Console.WriteLine("Response from finally Block");
            }
        }
    }
}
