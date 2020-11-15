using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            int a = 3;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 5;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second number");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

        }

        static void ExploreLoops()
        {
            // while loop
            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine($"Hello World, The counter is { counter }");
                counter++;
            }

            // for loop
            for(int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"Hello World, The index is { i }");
            }

            // nested loop - create rows and columns with using char for letters in nested loop
            for (int row = 0; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                Console.WriteLine($"The cell is ({row}, {column})");
                }
            }

        }

        static void DivisbleBy3()
        {
            int sum = 0;

            for(int i = 0; i <= 20; i++) 
            {
                if(i % 3 == 0)
                {
                    sum += i;
                }

            }
            Console.WriteLine($"The sum is { sum }");
        }
        static void Main(string[] args)
        {
            //ExploreIf();
            //ExploreLoops();
            DivisbleBy3();
        }
    }
}
