using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_ObjectorientedPractice
{
    internal class DuplicateElement
    {
        public void elements()
        {
            int[] arr = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("The total number of duplicate elements in the array is: " + count);
        }

    }

}
