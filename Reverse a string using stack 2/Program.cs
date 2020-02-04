using System;
using System.Collections;
using System.Collections.Generic;

namespace Reverse_a_string_using_stack_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=C5D2M9tMMKA
            //https://www.youtube.com/watch?v=-Y-23Mk-598

            string text = "Hello Berri";
            Console.WriteLine("Text: " + text);

            //code start
            Stack<char> stack = new Stack<char>();

            foreach (char c in text)
            {
                stack.Push(c);
            }

            //reset the value of our string text to empty.  This will prevent Hello BerriirreB olleH from printing.
            text = string.Empty;


            while (stack.Count > 0)
            {
                text += stack.Pop();
            }
            //code end

            Console.WriteLine("Text: " + text);
        }
    }
}
