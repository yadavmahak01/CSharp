using System;

namespace Arrays
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] daysofweek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine("Which day you want to display");
            Console.WriteLine("Monday=1 and so on");

            int iday = int.Parse(Console.ReadLine());
            string daytoshow = daysofweek[iday];

            Console.WriteLine($"The day is {daytoshow}");

            Console.WriteLine("*********************************");
            foreach (string day in daysofweek)
            {
                Console.WriteLine(day);
            }
        }
    }
}

