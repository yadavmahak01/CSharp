using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Interpolation using var

            var frnd = "Mahak";
            Console.WriteLine($"Hello {frnd}");

            //Printing
            string firstFriend = "Kani";
            string secondFriend = "Sen";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            //ToUpper() function
            string sayHello = "Gurgaon";
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            //Contains()
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            //StartsWith() and EndsWith() returns true or false
            string songLyric = "You say goodbye, and I say hello";
            Console.WriteLine(songLyric.StartsWith("You"));
            Console.WriteLine(songLyric.EndsWith("hello"));

            //Trim()- trim the leading and trailing spaces

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");


        }
    }
}
