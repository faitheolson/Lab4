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
                Console.WriteLine("Please enter an integer between 1 and 10:");
                int Input = int.Parse(Console.ReadLine());
                int Solution = Input;

                for (int i = 1; i < Input; i++)
                {
                    Solution *= (Input - i);
                }

                Console.WriteLine(Solution);

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
    }
}
