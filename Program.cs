using System;

namespace cSharpCourse
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;

            // addition
            int c = a + b;
            Console.WriteLine($"Additon: {c}");

            // subtration
            c = a - b;
            Console.WriteLine($"Subtraction: {c}");

            // multiplication
            c = a * b;
            Console.WriteLine($"Multiplication: {c}");

            // division
            c = a / b;
            Console.WriteLine($"Division: {c}");
        }

        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;

            int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine($"Order of operations: {d}");

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine($"Should be a decmial: {h} - but get an integer");

        }

        static void TestLimits()
        {
            // 
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;

            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            //
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            // 
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }
        
        static void WorkWithDoubles()
        {
            // double type example 1
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);
            // range of doubles 
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
            // 
            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

        static void WorkWithDecimals() 
        {
            // max and min range of decimals
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
            // double is less precise because of range
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);
            // decimal is more precise, M suffix to indicate use of decimal type
            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }

        static void AreaOfCircle() 
        {   // sqaure the radius - Math.pow also an option
            double radius = 2.50;
            // multiply by Math.PI 
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
        }
        static void Main(string[] args)
        {
            WorkingWithIntegers();
            OrderPrecedence();
            TestLimits();
            WorkWithDoubles();
            WorkWithDecimals();
            AreaOfCircle();
           
        }
    }
    
}
