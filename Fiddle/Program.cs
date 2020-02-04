using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] scores = { 75, 93, 88, 91 };

            int[] scores;
            //ask the user for the number of scores
            int size = GetInt("Enter number of scores: ");

            scores = new int[size];

            //take input for each score and put it in the array
            for (int i = 0; i < size; i++)
            {
                //i + 1 is showing 1-size instead of 0-(size-1)
                scores[i] = GetInt($"Enter score {i + 1}: ");
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

            bool flag;
            do
            {
                //output the scores (with user-friendly indices)
                for (int i = 0; i < scores.Length; i++)
                {
                    Console.WriteLine($"{i + 1}\t{scores[i]}");
                }

                //ask the user which score they want to update
                int index = GetInt("Which score do you want to update (-1 to exit): ");

                //if (index > 0)
                //{
                //    flag = true;
                //}
                //else
                //{
                //    flag = false;
                //}
                flag = (index > 0);

                if (flag)
                {
                    //get the new value for that element from the user
                    //remember to shift back from the user-friendly
                    index--; //shift back

                    // update the array
                    scores[index] = GetInt($"What's the new value? (was {scores[index]}): ");
                }
            } while (flag);

            //more demo

            //sorting using the Array class
            Array.Sort(scores);

            Console.WriteLine("Scores, sorted:");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            //this creates a reference (alias)
            int[] arr = scores;

            //changing the reference changes the original
            //scores is affected
            arr[1] = 25; //scores[1] is 25

            int[] arr2 = new int[scores.Length + 5];
            //copying using the object (instance) CopyTo method
            //the target array must already exist (instantiated)
            scores.CopyTo(arr2, 0);

            arr2[2] = 66;//arr2 changes, scores does not

            Console.WriteLine("Scores, again:");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            Console.WriteLine("\nArr2:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }

        //method: reusable block of code that can be called elsewhere in the program
        //method header: names it and gives more information 
        //header has ~5 parts:
        //(visibility/access modifier)
        //static or it's not (static or nothing)
        //return type: what info does the method give back (void if none)
        //name of method (follows rules for identifiers, Pascal case)
        //parameter list: the information it gets to start
        //method signature: just the name + parameter types 
        static int GetInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }
    }
}