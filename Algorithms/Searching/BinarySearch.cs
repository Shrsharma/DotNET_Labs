using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    class BinarySearch
    {
        public static void Do()
        {
            int[] numbers = new int[10] {23,37,43, 50, 57,60, 65,75,83,98 };
            foreach (int ele in numbers)
            {
                Console.WriteLine(ele + " ");
            }
            Console.WriteLine("\nEnter ele to be found:");
            string input = Console.ReadLine();
            int eleToSearch = Convert.ToInt32(input);

            int indexFound = -1;
            int left = 0;
            int right = numbers.Length - 1;
            while(left<=right && indexFound==-1)
            {
                int mid = (left + right) / 2;
                if(eleToSearch == numbers[mid])
                {
                    indexFound = ++mid;
                    break;
                }
                else if(eleToSearch < numbers[mid])
                {
                    right = mid - 1;

                }
                else
                {
                    left = mid + 1;

                }
            }
            if(indexFound!=-1)
            {
                Console.WriteLine("Element found at index:" + indexFound);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
