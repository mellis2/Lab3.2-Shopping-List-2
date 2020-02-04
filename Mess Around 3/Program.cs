using System;

namespace Mess_Around_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] testNumbers = { 6, 8, 9, 10, 15, 9 };

            //find the value of index given a specified number
            int integerIndex = Array.IndexOf(testNumbers, 9);

            Console.WriteLine(integerIndex);
            int count2 = 0;

            for (int i = 0; i < testNumbers.Length; i++)
            {
                if (integerIndex == testNumbers[i])
                {
                    Console.WriteLine($"Index {i} contains value {testNumbers[i]}");
                }


            }
        }
    }
}
