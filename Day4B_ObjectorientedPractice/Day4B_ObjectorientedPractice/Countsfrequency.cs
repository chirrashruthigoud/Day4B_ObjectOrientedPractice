using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_ObjectorientedPractice
{
    internal class Countsfrequency
    {
        public void Frequency()
        {
            // Create an array of integers
            int[] a = { 1, 2, 3, 4, 1, 2, 2, 3, 3, 3 };

            // Create a second array to store the frequency of each element
            int[] b = new int[a.Length];

            // Loop through each element in the array
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;

                // Compare the current element with every other element in the array
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        b[j] = -1; // Mark the second element as visited
                    }
                }

                // If the current element has not been visited, store its frequency
                if (b[i] != -1)
                {
                    b[i] = count;
                }
            }

            // Display the frequency of each element
            Console.WriteLine("Element    Frequency");
            for (int i = 0; i < a.Length; i++)
            {
                if (b[i] != -1)
                {
                    Console.WriteLine(a[i] + "        " + b[i]);
                }
            }

            // Wait for user input to close the console
            Console.ReadLine();
        }
    }
}
