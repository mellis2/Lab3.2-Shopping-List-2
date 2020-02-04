using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaration and instantion
            //space in memory is allocated
            //all elements are 0ed out
            //int[] scores = new int[16];

            //declaration only-- reference variable is created buy no space is allocated in memory.
            //string[] names;

            //instantion only
            //space for 16 string variable is allocated
            //each element is set to null
            //names = new string[16];

            //you can declare an array with information to start with
            //also this is an example of parrellel arrays
            //two arrays of the same size that hold related information
            //in the repective elements
            string[] names = { "Adam", "Bella", "Charly", "Dave" };
            int[] scores = {75, 93, 88, 70};

            //you can change the element in an array using the index
            //names[3] = "Peter";
            //scores[3] = 100;
            //scores[3] += 50;

            //iterting through the array (array traversal)
            for (int i = 0; i < names.Length; i++) 
            {
                Console.WriteLine($"{i}.\t{names[i]}\t{scores[i]}");
                //Console.WriteLine(scores[i]);
            }

            Console.Write("How many Students? : ");
            string input = Console.ReadLine();
            int size = int.Parse(input);

            int[] scores5 = new int[size];
            string[] names5 = new string[size];

            for (int i = 0; i < scores5.Length; i++) 
            {
                Console.WriteLine($"{i+1}\t\t{scores5[i]}\t\t{names5[i]}");
            }

        }
    }
}
