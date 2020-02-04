using System;
using System.Collections;
namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList names = new ArrayList();
            names.Add("Mike");
            names.Add("Soc");
            names.Add("Mike D.");
            names.Add("Brea");
            names.Add("Thomas");
            names.Add("Lucero");
            names.Add("Jacob");
            string[] names2 = {"Andrew", "Mark", "O", "John", "Tiia",
                "Brandon", "Sameer", "Laura", "Ardella"};
            foreach (string s in names2)
            {
                names.Add(s);
                //names.Insert(names.Count, s);
                //names.Insert(7, s);
            }
            names[0] = "Mike S.";
            //insert puts the value in the indicated index
            //after resizing the arraylist and pushing everything else back
            names.Insert(4, "Nic");
            foreach (string s in names)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Index of Tiia: " + names.IndexOf("Tiia"));
            Console.WriteLine("Index of Sameer: " + names.IndexOf("Sameer"));
            Console.WriteLine("Contains Riley: " + names.Contains("Riley"));
            Console.WriteLine("Contains Thomas: " + names.Contains("Thomas"));

            //take 5 new new names from the user and put them in the beginning of the existing ArrayList
            //ask the user which name to delete, and remove it

            Console.WriteLine("give me 5 names.");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("names: ");
                string newName = Console.ReadLine();
                names.Insert(0, newName);
            }

            Console.Write("Which name would you like to delete?: ");
            string deletedName = Console.ReadLine();
            names.Remove(deletedName);
        }
    }
}
