using System;

namespace Mess_Around
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51.
            //Prompt the user to enter a number. If the number is in the array, display the index at which it is located.
            int[] numbers = { 2, 8, 0, 24, 51, 8 };

            //int number = 8;
            Console.WriteLine("Please enter a number: ");
            string numberEntered = Console.ReadLine();
            int number;
            bool parseSuccessful6 = int.TryParse(numberEntered, out number);
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (number == numbers[i])
                {
                    Console.WriteLine($"***The value {number} WAS FOUND at index {i}***");
                    count += 1;
                    if (count == 0)
                    {
                        Console.WriteLine($"{number} was not found in the index");
                    }

                }
            }


            //Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. 
            //Prompt the user to enter an index. Display the element in the array at that index.


            


            ////int number = 8;
            //Console.WriteLine("Please enter a index: ");
            //string numberEntered2 = Console.ReadLine();
            //int number2;
            //bool parseSuccessful7 = int.TryParse(numberEntered2, out number2);
            //int count2 = 0;

            //Console.WriteLine($"The index {i} was found with value {number2} );

            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    if (number2 < numbers2.Length)
            //    {
            //        Console.WriteLine($"The index {i} was found with value {number2} );
            //        Console.WriteLine($"***The value {numbers2[number2]} WAS FOUND at index {i}***");
            //        count2 += 1;
            //    }

            //    else if (count2 == 0)
            //    {
            //        Console.WriteLine($"***The index entered does not exist in the array***");
            //    }

            //}

            




        }
        
    }
}
