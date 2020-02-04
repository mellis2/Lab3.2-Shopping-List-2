using System;
using System.Linq;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "one two three four five";

            //https://www.youtube.com/watch?v=o_cnd5gsXVo

            //.Select is a Linq function.  x => new String()) is a lamda expression. 
            //x represents each string in the string array that the split fuction is returning.
            //.Reverse is giving back an IEnumerable of char - IEnumerable<char> - which means a collection of characters. 
            //Now this reverse function will reverse the characters and it's returning the string as a collection of characters.
            //If you look at the string constructor, it expects a character.  So if we give it a character array then based
            //on that character array this constructor can construct a string. Now I'm going to convert this IEnumerable of character
            //to a character array simply by using ToArray function.  So this will return a character array to the string constructor 
            //and the string constructor is constructing a string from that. Now this is going to operate this lambda expression
            //will be applied for all strings that we have in this string array that this split function is returning.
            //So at the moment with this Select function what we have is a string array that contains five words but the characters 
            //in them are all reversed because of the reverse function called.  So now look at the select function, it is returning
            //an ienumerable of string, that means a collection of strings.  We have five words in that collection now what we want
            //in the result is a single back.  Now to get that single string we want to join all the strings that we have in this IEnumerable
            //of string. So to join those strings back together I am going to use join function of the string object.  
            //so string.join.  So how do you want to join all those sub string.  You want to join them so if you look at the result how do we 
            //want to join them? We want to join them using a single space.  So i'm going to use this separator as a single space 
            //and we have to specify our string here and that string array is whatever we have right here so I'm going to that and specify 
            //it right there and the semicolon so what is this join returning?, it's returning a single string back.  Let's store that in a
            //variable string, lets call it result string equals that. To make this more readable I'm going to bring the split function 
            //to the next line and similarly the select function.

            string resultString = string.Join(" ", inputString
                .Split(' ')
                .Select(x => new String(x.Reverse().ToArray())));

            Console.WriteLine(resultString);
        }
    }
}
