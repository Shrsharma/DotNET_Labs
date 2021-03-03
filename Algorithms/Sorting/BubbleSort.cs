using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class BubbleSort
    {
        public static void Do()
        {
            //string[] names = new string[5] { "Shah","Sharma","Pradhan","Dubey","Srivastav"};
            string[] names = new string[5] { "83", "70", "90", "45", "56" };
            Console.WriteLine("\nOriginal Array:");
            Print(names);
            string temp;
            for(int i=0;i<names.Length-1;i++)
            {
                for(int j=0;j<names.Length-i-1;j++)
                {
                    if(names[j+1].CompareTo(names[j])<0)
                    {
                        temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Array:");
            Print(names);
            
        }
        private static void Print(string[] names)
        {
            foreach(string ele in names)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
