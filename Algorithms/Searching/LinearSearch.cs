using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    class LinearSearch
    {
        public static void Do()
        {
            int[] numbers = new int[10] { 50, 60, 37, 65, 98, 43, 23, 57, 83, 75 };
            foreach(int ele in numbers)
            {
                Console.WriteLine(ele + " ");
            }
            Console.WriteLine("\nEnter ele to be found:");
            string input = Console.ReadLine();
            int eleToSearch = Convert.ToInt32(input);
            bool flag = false;
            for(int i=0;i<numbers.Length;i++)
            {
                if (numbers[i]==eleToSearch)
                {
                    flag = true;
                    Console.WriteLine("Ele found at index {0}", i);
                    break;
                }

            }
            if(!flag)
            {
                Console.WriteLine("Ele not found");
            }
        }
    }
}
