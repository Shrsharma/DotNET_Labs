using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class SelectionSort
    {
        public static void Do()
        {
            int[] numbers = new int[5] { 7, 5, 3, 9, 1 };
            Console.WriteLine("\nOriginal Array:");
            Print(numbers);
            for(int i=0; i<numbers.Length-1; i++)
            {
                int min_ele = i;
                for(int j=i+1; j<numbers.Length; j++)
                {
                    if(numbers[j]<numbers[min_ele])
                        min_ele = j;
                    int temp = numbers[min_ele];
                    numbers[min_ele] = numbers[i];
                    numbers[i] = temp;
                }
                Console.WriteLine("Array after pass:"+(i+1));
                Print(numbers);
            }
            Console.WriteLine("Sorted Array:");
            Print(numbers);
        }
        private static void Print(int[] numbers)
        {
            foreach(int ele in numbers)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
