using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class InsertionSort
    {
        public static void Do()
        {
            int[] numbers = new int[5] { 7, 5, 3, 9, 1 };
            Console.WriteLine("\nOriginal Array:");
            Print(numbers);

            for(int i=1; i<numbers.Length;i++)
            {
                int key = numbers[i];
                int j = i - 1;
                while(j>=0 && numbers[j]>key)
                {
                    numbers[j + 1] = numbers[j];
                    j = j - 1;

                }
                numbers[j+1] = key;
            }

            Console.WriteLine("Sorted Array:");
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
