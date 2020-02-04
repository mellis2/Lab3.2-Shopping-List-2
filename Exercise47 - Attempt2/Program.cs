using System;
using System.Collections.Generic;

namespace Exercise47___Attempt2
{
    class Program
    {
        static void Main(string[] args)
        {
           bool proceed = true;

            List<string> stringList = new List<string>();

            while (proceed == true)
            { 
                
                Console.Write("Enter some text: ");
                string stringInput = Console.ReadLine();
                string userString = stringInput;
                stringList.Add(userString);

                Console.Write("You have entered: ");
                foreach (string str in stringList) 
                {
                    Console.Write($"{str} "); ;
                }
                Console.WriteLine();
                

                Console.Write("Would you like to continue (y/n)");
                string additionalStringInput = Console.ReadLine();
                string additionalString = additionalStringInput;

                if (additionalString == "y")
                {
                    proceed = true;
                }
                else 
                {
                    Console.WriteLine("Goodbye");
                    proceed = false;
                }
            }
           
        }
    }
}
