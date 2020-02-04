using System;
using System.Collections.Generic;

namespace Exercise_35
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] animal = { "cow", "elephant", "jaguar", "horse", "crow" };
            Console.Write("Please enter 2 indices separated by a space: ");
            string userInput = Console.ReadLine();
            int indexZero = int.Parse(userInput.Split(" ")[0]);
            int indexOne = int.Parse(userInput.Split(" ")[1]);

            Console.WriteLine($"The value at index {indexZero} is {animal[indexZero]}.");
            Console.WriteLine($"The letter at index {indexOne} is {animal[indexOne]}");
        }
    }
}

