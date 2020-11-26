using System;

namespace exercises1
{
    class Program
    {   
        static void Variables() 
        {
            // bool ifFalse = true;
            // string message = "Hello World!";
            // int score = 10;
            // double grade = 80.1;
            // char letter = 'a';

            var ifFalse = false;
            var message = "Hello World!";
            var score = 10;
            var grade = 80.1;
            var letter = 's';

            Console.WriteLine($" {ifFalse}, {message}, {score}, {grade}, {letter}");
        }

        static void MinMax()
        {
            int max = 2147483647;
            max++;
            Console.WriteLine(max);
        }

        static void Operators()
        {
            int x = 10;
            int y = 6;

            // int z1 = x++;
            // int z2 = ++y;

            // Console.WriteLine($"{x}, {y}, {z1}, {z2}");

            // int a = x + y;
            // int b = x - y;
            // int c = x / y;

            // Console.WriteLine($"{a}, {b}, {c}");

            if(x % 2 == 0)
            {
                bool isEven = true;
                Console.WriteLine(isEven);
            }
            
            if(y % 3 == 0)
            {
                bool byThree = false;
                Console.WriteLine(byThree);
            }

            double threeDecimals = Math.Round(1.238135, 3);
            Console.WriteLine(threeDecimals);

            int z = 9;

            double a = 10.1;
            double b = 12.3;
            double c = 54.2;

            x = double(10);


        }

        /// <summary>
        /// Just testing out a comment in XML.
        /// </summary>
        static void Main(string[] args)
        {
            //Variables();
            //MinMax();
            Operators();
        }
    }
}
