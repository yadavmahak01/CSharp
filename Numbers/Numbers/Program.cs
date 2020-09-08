using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic maths operation
            int a = 12;
            int b = 3;
            int c = a + b;
            Console.WriteLine(c);

            //Precedence
            int x = 5;
            int y = 1;
            int z = 9;
            int value = x + y * z;
            Console.WriteLine(value);

            //Using paranthesis
            int q = 2;
            int w = 12;
            int e = 4;
            int res= (q + w) / e;
            Console.WriteLine(res);

            //Mathematical minimum and maximum limits
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            //Double data type
            double n1 = 19;
            double n2= 23;
            double n3= 8;
            double n4= (n1 + n2) / n3;
            Console.WriteLine(n4);

            //The M suffix - indicate that a constant should use the decimal type.
            decimal n5 = 1.0M;
            decimal n6= 3.0M;
            Console.WriteLine(n5 / n6);

            //area calculation using Math.PI
            double radius = 3.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);

        }
    }
}
