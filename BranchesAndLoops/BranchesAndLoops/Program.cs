using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement
            Console.WriteLine("IF STATEMENT");
            int a = 5;
            int b = 11;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");


            //if-else
            Console.WriteLine("*******************************************");
            Console.WriteLine("IF-ELSE STATEMENT");
            int n1= 5;
            if (n1%2==0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Odd number");

            //if-else with and condition
            Console.WriteLine("*******************************************");
            Console.WriteLine("IF-ELSE WITH CONDITION");
            int a1 = 5;
            int b1 = 3;
            int c1 = 4;
            if ((a1 + b1 + c1 > 10) && (a1 == b1))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            //while loop
            Console.WriteLine("*******************************************");
            Console.WriteLine("WHILE LOOP");
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            //do while loop
            Console.WriteLine("*******************************************");
            Console.WriteLine("DO WHILE LOOP");
            int counter1 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter1++;
            } while (counter1 < 10);

            //for loop
            Console.WriteLine("*******************************************");
            Console.WriteLine("FOR LOOP");
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The counter is {index}");
            }

            //nested for loop
            Console.WriteLine("*******************************************");
            Console.WriteLine("NESTED FOR LOOP");

            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }

            //Branches and loops
            Console.WriteLine("*******************************************");
            Console.WriteLine("BRANCHES AND LOOPS");
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");


        }
    }
}
