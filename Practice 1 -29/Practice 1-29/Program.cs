using System;

namespace Practice_1_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter 5 integers");

            for(int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine(numbers[i] = int.Parse(Console.ReadLine()));
              
            }
        }
    }
}
