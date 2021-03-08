using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class RecursionProgram
    {
        public static void Do()
        {
            int[] numbers = new int[10] { 64, 57, 32, 98, 71, 84, 62, 77, 54, 80 };
            Print(numbers, 0);
            Console.WriteLine("Printing using recursion done successfully!!");
        }

        private static void Print(int[] numbers, int curr_index)
        {
            Console.WriteLine(numbers[curr_index]);
            if(curr_index < numbers.Length-1)
            {
                Print(numbers, curr_index + 1);
            }
        }
    }
}
