using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack_Reverse_a_word_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, please enter a few words: ");
            string text = Console.ReadLine();
            

           // string text = "Taco Bell Chalupa";
            Console.WriteLine(text);

            Stack<char> stack = new Stack<char>();

            foreach (char c in text)
            {
                stack.Push(c);
            }
            //Console.WriteLine(text.Length);
           
            text = string.Empty;

            while (stack.Count > 0) 
            {
                text += stack.Pop();
            }

            Console.WriteLine(text);
        }
        string ReverseString(string userString) 
        {
            
            if(true)
            return true;
        }
    }
}
