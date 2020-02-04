using System;

namespace Assessment_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstrate the ability to create arrays
            int[] luckyNumbers = { 2, 4, 7, 9, 15};
            string[] ellisBrothers = {"Mike", "John", "Tim", "Tom", "Mark"};

            int[] luckyNumbers2 = new int[5];
            luckyNumbers2[0] = 5;
            luckyNumbers2[1] = 7;
            luckyNumbers2[2] = 9;
            luckyNumbers2[3] = 1;
            luckyNumbers2[4] = 4;
            Console.WriteLine();

            //Can subsequently can the value of an element in an array
            luckyNumbers2[0] += 5;
            Console.WriteLine(luckyNumbers2[0]);

            //iterating through an array
            for (int i = 0; i < luckyNumbers2.Length; i++) 
            {
                Console.WriteLine($"{i}\t\t{luckyNumbers[i]}\t\t{ellisBrothers[i]} \t\t{luckyNumbers2[i]}");
            }

            

            Console.Write("Please enter the number of students: ");
            
            string numberOfStudentsInput = Console.ReadLine();
            int numberOfStudents;

            bool parseSuccessful = int.TryParse(numberOfStudentsInput, out numberOfStudents);

            int[] studentScores = new int[numberOfStudents];

            Console.WriteLine($"Please enter the scores of the {numberOfStudents} students");
            for (int i = 0; i < studentScores.Length; i++) 
            {

                studentScores[i] = int.Parse(Console.ReadLine());
                 
            }
            for (int i = 0; i < studentScores.Length; i++) 
            {
                Console.WriteLine($"{i + 1}\t\tStudent score is {studentScores[i]}");
            }

            int sum = 0;
            int min = studentScores[0];
            int max = studentScores[0];

            for (int i = 0; i < studentScores.Length; i++) 
            {
                sum += studentScores[i];
                if (studentScores[i] < min)
                {
                    min = studentScores[i];
                }
                else if (studentScores[i] > max)
                {
                    max = studentScores[i];
                }

            }
            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"Average = {sum / studentScores.Length}");
            Console.WriteLine($"min = {min}");
            Console.WriteLine($"max = {max}");

            int[] numbers = { 2, 8, 0, 24, 51 };

            Console.WriteLine(numbers[3]);
            Console.Write("Please enter a number: ");
            string numberInput = Console.ReadLine();
            int number = 0;
            bool parseSuccessful4 = int.TryParse(numberInput, out number);

            for (int i = 0; i < numbers.Length; i++) 
            {

                if (number == numbers[i])
                {
                    Console.WriteLine($"The value {number} was found at index {i}");
                }
                else 
                {
                    Console.WriteLine("The value could not be found");
                    break;
                }

            }



        }
    }
}
