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

                int num1 = ReadInputFromUser("num1");
                int num2 = ReadInputFromUser("num2");



                //custom exception
                if (num2 > 10000)
                {
                    throw new ArgumentException("number 2 can not be greater than 1000");
                }

                double result = num1 / num2;
                Console.WriteLine($"Result = {result}");
               
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
        static int ReadInputFromUser(string promt)
        {
            while (true)
            {
                
                try
                {
                    Console.Write($"Enter {promt} =  ");
                    string input = Console.ReadLine() ?? "";
                    if (string.IsNullOrEmpty(input))
                    {
                        //throw new ArgumentNullException("num1 can not be null or empty");option 1
                        Console.WriteLine($"{promt} can not a nul expresstion"); //option  2
                        continue;
                    }
                    return Convert.ToInt32(input);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("input can not be null or empity");
                }
                catch (OverflowException)
                {
                    Console.WriteLine(" Value was either too large or too small for an Int32.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter  a valid Number");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{ e.Message}");
                }
            }
        }
    }
}
