using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat == true)
            {
                Console.WriteLine("Please enter an integer between 1 and 20:");
                long Input = long.Parse(Console.ReadLine());
                long Solution = Input;

                // **** The For Loop Version is commented out
                //for (int i = 1; i < Input; i++)
                //{
                //    Solution *= (Input - i);
                //}

                Console.WriteLine($"The factorial of {Input} is {Factorial(Input)}!");

                Console.WriteLine("Would you like to try again? (y/n)");
                string again = Console.ReadLine();

                if (again != "y" && again != "Y")
                {
                    repeat = false;
                    Console.Clear();
                    Console.WriteLine("Goodbye!!!");
                    break;
                }

                Console.Clear();

            }
        }

        public static long Factorial(long Input)
        {
            //while (Input - 1 > 0)
            //{
            //    return Input *= (Factorial(Input - 1));
            //}
            //return Input;

            if (Input - 1 == 0)
            {
                return Input;
            }

            return Input *= (Factorial(Input - 1));

        }
    }
}
