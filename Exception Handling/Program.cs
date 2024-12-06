using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wecome to ta calculator APP");
            try
            {
                Console.Write("Enter Number1 = ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Number2 = ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                //custom exception
                if(number2 > 10000)
                {
                    throw new ArgumentException("number 2 can not be greater than 1000");
                }

                double result = number1 / number2;
                Console.WriteLine($"Result = {result}");
               
            }
            catch(OverflowException)
            {
                Console.WriteLine(" Value was either too large or too small for an Int32.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter  a valid Number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error! Can not divide by ZERO!!!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception handaling  : {e}");
            }
            finally
            {
                Console.Write("Goodbye!!");
            }

        }
    }
}
