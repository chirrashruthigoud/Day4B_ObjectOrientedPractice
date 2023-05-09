using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_ObjectorientedPractice
{
    public class ReverseWord
    {
        public void PrintReverse()
        {
            Console.WriteLine("Enter the string to reverse : ");
            string name = Console.ReadLine();
            string type = "";
            int length = name.Length;
            int i = 0;
            for (i = length - 1; i >= 0; i--)
            {
                type = type + name[i];
            }
            Console.WriteLine($"The Reverse of String is :  {type}");
        }
    }
}
