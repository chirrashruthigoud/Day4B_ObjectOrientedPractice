using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_ObjectorientedPractice
{
    internal class SumofAllDigits
    {
        public void sumofdigits()
        {
            Console.Write("Enter a number: ");
            //string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine("The sum of the digits is: " + sum);
        }
    }
}
