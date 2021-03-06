﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> inventory = new Dictionary<string, double>()
            {
                                                            { "apple", 0.99},
                                                            { "banana",0.59},
                                                            { "cauliflower",1.59},
                                                            { "dragonfruit",2.19},
                                                            { "elderberry",1.79},
                                                            { "figs",2.09},
                                                            { "grapefruit",1.99},
                                                            { "honeydew",3.49},
            };


            Console.WriteLine("Welcome to Lucero's Market");

            Dictionary<string, int> userLists = new Dictionary<string, int>()
            {                                               { "apple", 0},
                                                            { "banana",0},
                                                            { "cauliflower",0},
                                                            { "dragonfruit",0},
                                                            { "elderberry",0},
                                                            { "figs",0},
                                                            { "grapefruit",0},
                                                            { "honeydew",0}
            };


            do
            {
                PrintMenu(inventory);

                Console.Write("\nWhat item would you like to order? ");
                string userInput = Console.ReadLine().ToLower();


                while (inventory.ContainsKey(userInput) == false)
                {

                    Console.WriteLine("\nSorry, we don't have those. Please try again.");
                    Console.Write("\nWhat item would you like to order? ");
                    userInput = Console.ReadLine().ToLower();
                }

                if (inventory.ContainsKey(userInput))
                {

                    userLists[userInput] += 1;
                    Console.WriteLine($"\nAdding {userInput} to cart at ${inventory[userInput]}");
                }

            } while (UserContinue());

            PrintReceipt(inventory, userLists);

            static void PrintMenu(Dictionary<string, double> inventoryDic)
            {
                Console.WriteLine(String.Format("\n\n{0,-25} {1,-10}", "ITEM", "PRICE"));
                Console.WriteLine(new string('=', 31));

                foreach (KeyValuePair<string, double> kvPair in inventoryDic)
                {
                    Console.WriteLine(String.Format("{0,-25} {1,-10}", kvPair.Key, $"{kvPair.Value.ToString("C", CultureInfo.CurrentCulture)}"));
                }
            }
            static void PrintReceipt(Dictionary<string, double> inventoryDic, Dictionary<string, int> userList)
            {
                Console.WriteLine("\n\nHere's what you got:");
                Console.WriteLine(new string('=', 31));

                double itemPrice = 0;

                int count = 0;
                foreach (KeyValuePair<string, int> kvPair in userList)
                {

                    if (kvPair.Value > 0)
                    {

                        Console.WriteLine($"{(kvPair.Value)} X {kvPair.Key} ({(inventoryDic[kvPair.Key]).ToString("C", CultureInfo.CurrentCulture)} each) = {((inventoryDic[kvPair.Key]) * (kvPair.Value)).ToString("C", CultureInfo.CurrentCulture)}");
                        itemPrice += inventoryDic[kvPair.Key];
                        count++;

                    }
                }
                Console.WriteLine($"\nAverage price per item in order was {(itemPrice / count).ToString("C", CultureInfo.CurrentCulture)}");
            }

            static bool UserContinue()
            {
                char key;
                do
                {
                    Console.Write("\nWould you like to order anything else? Please enter (y/n) ");
                    key = Console.ReadKey().KeyChar;
                    key = char.ToLower(key);
                    if (key == 'n')
                    {
                        return false;
                    }
                    Console.WriteLine();

                } while (key != 'y');
                return true;
            }

        }
    }
}
//    string[] animal = { "cow", "elephant", "jaguar", "horse", "crow" };
//    Console.Write("Please enter 2 indices separated by a space: ");
//    string userInput = Console.ReadLine();
//    int indexZero = int.Parse(userInput.Split(" ")[0]);
//    int indexOne = int.Parse(userInput.Split(" ")[1]);

//    Console.WriteLine($"The value at index {indexZero} is {animal[indexZero]}.");
//    Console.WriteLine($"The letter at index {indexOne} is {animal[indexOne]}");
//}