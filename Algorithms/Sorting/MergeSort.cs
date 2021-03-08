using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class MergeSort
    {
        public static void Do()
        {
            int[] numbers = { 64, 57, 32, 98, 71, 85 };
            Print(numbers);
        }

        private static void Print(int[] numbers)
        {
            foreach (int ele in numbers)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
