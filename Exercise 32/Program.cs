using System;

namespace Exercise_32
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. Prompt the user to enter a number. If the number is in the array, display the index at which it is located.

            int[] numbers = { 2, 8, 0, 24, 51 };
            int index;

            Console.WriteLine(numbers[3]); //to view the value of an array at a specific index.
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            int element;

            bool parseSuccessful = int.TryParse(userInput, out element);

            for (int i = 0; i < numbers.Length; i++) 
            { 
                if(element == numbers[i]) 
                {
                    Console.WriteLine($"The value {element} can be found at index {i}");
                }
                else 
                {
                    Console.WriteLine("That value cannot be found in the array.");
                    break;
                }
            }
























            //int[] numbers = { 2, 8, 0, 24, 51 };
            //int element = 8;
            //int index;

            //for (int i = 0; i < numbers.Length; i++) 
            //{ 
            //    if(element == numbers[i]) 
            //    {
            //        Console.WriteLine(index = i);
            //    }
            //}
        }
    }
}
