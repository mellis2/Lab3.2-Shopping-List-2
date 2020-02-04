using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab3._2_Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> inventory = new Dictionary<string, double>();
            inventory["apple"] = 0.99;
            inventory["banana"] = 0.59;
            inventory["cauliflower"] = 1.59;
            inventory["dragonfruit"] = 2.19;
            inventory["elderberry"] = 1.79;
            inventory["figs"] = 2.09;
            inventory["grapefruit"] = 1.99;
            inventory["honeydew"] = 3.49;

            Console.WriteLine("Item\t\tPrice");
            Console.WriteLine("=======================");

            foreach (KeyValuePair<string, double> key in inventory)
            {
                Console.WriteLine($"{key.Key,-15} ${key.Value}");

            }
            List<string> shoppingListKey = new List<String>(); ////////////////////////
            foreach (KeyValuePair<string, double> key1 in inventory)
            {
                shoppingListKey.Add(key1.Key);
            }

            List<string> shoppingListValue = new List<String>();

            foreach (string shoppingGuide in shoppingListKey)
            {

                Console.WriteLine(shoppingGuide);

                    
            }
            foreach (KeyValuePair<string, double> value1 in inventory)
            {
                shoppingListKey.Add(value1.Key);
            }

            foreach (var price in shoppingListValue)
            {
                Console.WriteLine(price);
                {

                }
                Console.WriteLine();
            }
        }
             
    }
}
