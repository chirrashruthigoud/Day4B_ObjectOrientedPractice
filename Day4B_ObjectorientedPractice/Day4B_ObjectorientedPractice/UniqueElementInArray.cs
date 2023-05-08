using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_ObjectorientedPractice
{
    internal class UniqueElementInArray
    {
        public void PrintElement()
        {
            int[] arr = { 1, 2, 3, 3, 4, 5, 5 };
            Console.WriteLine("The unique elements in the array are:");
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                    }
                }
                if (!isDuplicate)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
