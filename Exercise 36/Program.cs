using System;

namespace Exercise_36
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 11, 10, 9, 8 };
            string[] strings = { "Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking" };

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"{numbers[i]} {strings[i]}");
            }
            Console.WriteLine("Goodbye");

        }
    }
}
