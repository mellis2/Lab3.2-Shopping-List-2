using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration and instantiation
            //space in memory is allocated
            //all elements are 0ed out
            int[] scores1 = new int[16];

            //declaration only--reference variable is created but
            //  no space is allocated in memory
            string[] names1;

            //instantiation only
            //space for 16 string variables is allocated
            //each element is set to null
            names1 = new string[16];

            //arrays can be sized at runtime
            // (can be based on user input)
            Console.Write("How many students? ");
            string input = Console.ReadLine();
            int size = int.Parse(input);

            string[] names2 = new string[size];

            //filling an array from input
            //for (int i = 0; i < names2.Length; i++)
            for (int i = 0; i < size; i++)
            {
                Console.Write($"What's the name for position {i}? ");
                names2[i] = Console.ReadLine();
            }

            //verify that the names are in
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(names2[i]);
            }

            //you can declare an array with information to start with
            string[] names = { "Adam", "Bella", "Charly", "Dave" };
            int[] scores = { 75, 93, 88, 91 };

            //also, this is an example of parallel arrays
            // two arrays of the same size that hold related information
            // in the respective elements

            //you can change an element in an array using the index
            names[3] = "Peter";
            scores[3] = 100;
            scores[3] += 50;//enhanced assign the value

            //iterating through the array (array traversal)
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i}.\t{names[i]}\t{scores[i]}");
            }

        }
    }
}