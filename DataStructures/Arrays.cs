using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Arrays
    {
        public static void Do()
        {
            string[] students = new string[5] { "ABC", "DEF", "GHI", "MNO", "XYZ" };

            string[] subject = new string[5];
            subject[0] = "CN";
            subject[1] = "OS";
            subject[2] = "SE";
            subject[3] = "DBMS";
            subject[4] = "CO";

            int[] marks = new int[5];
            marks[0] = 87;
            marks[1] = 92;
            marks[2] = 79;
            marks[3] = 95;
            marks[4] = 86;

            foreach (var ele in students)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
