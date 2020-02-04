using System;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack stack = new Stack();
            
            Console.WriteLine("Welcome to the Word Stack/Queue");

            do
            {
                Console.WriteLine("Please enter a word or -1 to end: ");

                string word = Console.ReadLine();
                word = Console.ReadLine();

                if (word != "-1") 
                {
                    stack.Push(word);
                }

            } while (word != "-1");

            Console.WriteLine("Goodbye");

        }
    }
}
