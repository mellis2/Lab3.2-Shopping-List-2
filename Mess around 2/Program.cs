using System;
using System.Collections;
using System.Collections.Generic;

namespace Mess_around_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> food = new List<string>();
            food.Add("Pizza");
            food.Add("Pad Thai");
            food.Add("Nachos");
            food.Insert(0, "Mozzarella Sticks");
            food.Remove("Nachos");



            //Adds burger to list after every iteration through the for loop
            for (int i = 0; i < 8; i++)

            {
                food.Add("Burger");
            }

            //Displays every item in the list
            foreach (string snack in food)
            {
                Console.WriteLine(snack);
            }

            Console.WriteLine("***************************************************");


            //can use for loop to display index and all items in list.
            for (int i = 0; i < food.Count; i++)
            {
                Console.WriteLine($"{i + 1,3} {food[i]}");
            }

            food.RemoveAll(s => s == "Burger");

            Console.WriteLine("After RemoveAll:");
            foreach (string item in food)
            {
                Console.WriteLine(item);
            }

            List<int> luckyNumbers = new List<int>();
            luckyNumbers.Add(5);
            luckyNumbers.Add(2);
            luckyNumbers.Add(3);
            luckyNumbers.Add(2);

            luckyNumbers.RemoveAll(i => i == 2);

            for (int i = 0; i < luckyNumbers.Count; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            //created ArrayList and added items to ArrayList

            ArrayList names = new ArrayList();
            names.Add("Mike");
            names.Add("Soc");
            names.Add("Mike D.");
            names.Add("Brea");
            names.Add("Thomas");
            names.Add("Lucero");
            names.Add("Jacob");

            //Created an array of strings
            string[] names2 = {"Andrew", "Mark", "O", "Tiia", "John",
                "Brandon", "Sameer", "Laura", "Ardella", "Riley"};

            foreach (string nickname in names2)
            {
                names.Add(nickname);
                //names.Insert(names.Count, nickname);
                //names.Insert(7, nickname);

            }
            names[0] = "Mike S.";

            //insert puts the value in the indicated index
            //after resizing the arraylist and pushing everything else back
            names.Insert(4, "Nic");

            //removing from AL
            //Remove: removes the FIRST occurrence of the object (if found)
            names.Remove("Tiia");
            names.Remove("Peter");//no exception if the value isn't found

            names.RemoveAt(names.Count - 1); //removes the last item (Riley)
            //names.RemoveAt(-1); //exception
            //names.RemoveAt(100);

            foreach (string s in names)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Index of Tiia: " + names.IndexOf("Tiia"));
            Console.WriteLine("Index of Sameer: " + names.IndexOf("Sameer"));

            Console.WriteLine("Contains Riley: " + names.Contains("Riley"));
            Console.WriteLine("Contains Thomas: " + names.Contains("Thomas"));

            //take five new names from the user and put them in the
            //  beginning of the existing ArrayList
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a new name: ");
                string str = Console.ReadLine();
                //names.Insert(0, str);
                names.Insert(i, str);
            }

            //ask the user which name to delete, and remove it
            Console.Write("What name do you want to delete? ");
            string str2 = Console.ReadLine();
            names.Remove(str2
                );

            Console.WriteLine("Final List:");
            foreach (string s in names)
            {
                Console.WriteLine(s);
            }

            int[] testNumbers = {6, 8, 9, 10, 15};


            //find the value of index given a specified number
            //int integerIndex = Array.IndexOf(testNumbers, 9);

            Console.Write("Enter an index: ");
            string userIndexInput = Console.ReadLine();
            string userIndex = userIndexInput;
            int userIndexInt;

            bool parseSuccessful = int.TryParse(userIndex, out userIndexInt);


            Console.WriteLine($"The value at index {userIndex} is {testNumbers[userIndexInt]}.");
            


        }


    }
}
