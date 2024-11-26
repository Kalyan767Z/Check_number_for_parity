using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_number_for_parity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your number: ");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                if (number % 2 == 0)
                    Console.WriteLine("Your number is even");
                
                else Console.WriteLine("Your number is odd");
            }
            else Console.WriteLine("Wrong number");

        }
    }
}
