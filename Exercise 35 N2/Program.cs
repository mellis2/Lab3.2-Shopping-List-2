using System;

namespace Exercise_35_N2
{
    class Program
    {
        static string[] str = { "cow", "elephant", "jaguar", "horse" };
        static int[] parsed = new int[5];
        static void Main(string[] args)
        {
            string input = GetInput();
            string[] inputs = input.Split(' ');
            for (int i = 0; i < inputs.Length; i++)
            {
                parsed[i] = int.Parse(inputs[i]);
            }



            string selection = str[parsed[0] - 1];
            Console.WriteLine("Your selections is " + selection);
            Console.WriteLine("This is your letter in your word that you selected: " + str[parsed[0] - 1].Substring(parsed[1] - 1, 1));
            //Char[] chars = new char[10];
            //char = selection.ToCharArray;
        }

        static string GetInput()
        {
            Console.WriteLine("Please enter two indices separated by spaces.  ");
            return Console.ReadLine();
        }




    }

}
