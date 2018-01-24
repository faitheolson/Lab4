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
            Console.WriteLine("Please enter an integer between 1 and 10:");
            int Input = int.Parse(Console.ReadLine());
            int Solution = Input;

            for (int i = 1; i < Input; i++)
            {
                Solution *= (Input-i);
            }

            Console.WriteLine(Solution);
            
        }
    }
}
