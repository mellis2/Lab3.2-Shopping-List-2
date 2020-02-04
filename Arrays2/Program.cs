using System;
namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] scores;
            //ask the user for the number of students


            Console.Write("Please enter number of students: ");
            int studentNumber = int.Parse(Console.ReadLine());

            int[] scores = new int[studentNumber];
            //ask the user for the number of scores
            Console.WriteLine("Please enter student scores: ");

            //take input for each score and put it in the array.
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = int.Parse(Console.ReadLine());
            }

            //take input for each score and put it in the array
            //int[] scores = { 75, 93, 88, 91 };
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
            //sorting using the Array class
            Array.Sort(scores);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            Console.Write("Which Score do you want to change: "); //start 1
            int indexToChange = int.Parse(Console.ReadLine());
            Console.Write("What do you want to change it to?");
            int newScore = int.Parse(Console.ReadLine());


            /////using input here as the index of the array
            scores[indexToChange] = newScore;

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);  //end 2
            }

            //this creates a reference alias
            int[] arr = scores;
        }

        //changing the reference changes the original
        //scores is affected
        //arr[1] = 25; //scores[1] is 25

        //int[] arr2 = new int[scores.Length = 5]; //wanted to add 5 to length
        //copying using the object (instance) CoptTO method
        //scores.CopyTo(arr2, 0);
    }

        //method is a reusable block of code that can be called elsewhere in the program
        //method header: names it and gives more information
        //header had ~5 parts:
        //header has 3+ parts:
        //(visibility/access modifer)
        //static or it's not (static or nothing)
        //return Type: what info does the method give back (void if none) 
        //name of method(follows rules for identifiers, Pascal case)
        //parameter list: the information it gets to start
        //method signature: just the name + parameter types
        
    }      
    
    
    
}

