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
            
        }
        static void Main(string[] args)
        {
            //WorkingWithIntegers();
            OrderPrecedence();
        }
    }
    
}
