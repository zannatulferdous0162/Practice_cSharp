using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Validation_and_loop_termination
{
    internal class Program

    {
        public static int CalculateSquare(int num)
        {
            return num * num;
        }
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Enter the number from 1 to 10 or write Quite exit the APP");
                string input = Console.ReadLine() != null ? Console.ReadLine() : "";
                input = input.ToLower().Trim();

                if (input == "quit")
                {
                    Console.WriteLine($"Thanks for using the app....GoodBye!!");
                    break;
                }
                else if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine($"Please enter a valid input. Please give a number");
                    continue;
                }
                else if (!(number >= 1 && number <= 10))
                {
                    Console.WriteLine($"Not a range of  1-10");
                    continue;
                }
                else
                {
                    
                    int square = CalculateSquare(number);
                   Console.WriteLine($"Square of {number}  = {square}");
                }

            }
        }
    }
}
