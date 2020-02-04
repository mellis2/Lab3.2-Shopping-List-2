using System;

namespace Fiddle___reworked_without_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for the number of scores
            Console.Write("Enter number of scores in array: ");
            string sizeInput = Console.ReadLine();
            int size;

            bool parseSuccessful = int.TryParse(sizeInput, out size);
            int[] scores = new int[size];

            //take input for each score and put it in the array
            Console.WriteLine("Please enter values for 5 elements: ");
            for (int i = 0; i < scores.Length; i++)
            {
                string scoresInput = Console.ReadLine();
                int scores2;
                bool parseSuccessful2 = int.TryParse(scoresInput, out scores2);
                scores[i] = scores2;
                //scores[i] = int.Parse(Console.ReadLine());  // ask how to parse this tommorrow.


            }
            //add, average, and find the min and max of an array
            int sum = 0;
            int min = scores[0]; //safe bet: start with a value from array
            int max = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];//add this specific score, this iteration

                if (scores[i] < min)
                {
                    min = scores[i];
                }
                else if (scores[i] > max)
                {
                    max = scores[i];
                }
            }
            //sum
            Console.WriteLine($"Total: {sum}");

            //min
            Console.WriteLine($"Lowest: {min}");

            //max
            Console.WriteLine($"Highest: {max}");

            //average
            double average = (double)sum / scores.Length;
            Console.WriteLine($"Average: {average}");

        }
    }
}
    
