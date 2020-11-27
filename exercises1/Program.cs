using System;
using System.Collections.Generic;


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

            int a2 = (int)a;
            int b2 = (int)b;
            int c2 = (int)c;

            double x2 = (double)x;
            double y2 = (double)y;
            double z2 = (double)z;
            
            Console.WriteLine($"Converted to Int: {a2}, {b2}, {c2}");
            Console.WriteLine($"Converted to Double: {x2}, {y2}, {z2}");
        }

        static void Strings()
        {
            // Console.WriteLine("\\testing\t\'escape\'\nsequences");
            // Console.WriteLine(@"c:\testing\string\literal:");
            
            string message1 = "Testing";
            string message2 = "Concatation";
            string message3 = message1 + ' '+ message2;

            // Console.WriteLine(message3);
            // Console.WriteLine(message3.Length);

            string lengthLessThan3 = "Hello World";

            // for(int i = 0; i < lengthLessThan3.Length; i+=2)
            // {
            //     Console.WriteLine(lengthLessThan3[i]);
            // }

            // Console.WriteLine(message1.ToUpper());
            // Console.WriteLine(message2.ToLower());

            string newMessage = "";

            for(int i = 1; i < lengthLessThan3.Length - 1; i++)
            {
                newMessage += lengthLessThan3[i];
            }
            
            // Console.WriteLine(newMessage);

            string x = "testing";
            char y = 'e';

            var Letters = new List<char> {'t','e','s','t','i','n','g'};

            for(int i = 0; i < x.Length; i++)
            {
                if(Letters[i] == y)
                {
                    //Console.WriteLine(i);
                    break;
                }
            }

            if(x.Contains(y))
            {
                bool doesContain = true;
                //Console.WriteLine(doesContain);
            }

            //Console.WriteLine(String.Join(", ", Letters));
            // Letters.ForEach(Console.WriteLine);

            // get file name from path 

            string path = "c:\\foo\\bar.txt";

            string[] splitPath = path.Split("\\");

            string fileName = splitPath[splitPath.Length - 1];

            // Console.WriteLine(fileName);

            // get the drive code letter in uppercase

            char drive = path[0];

            // Console.WriteLine(char.ToUpper(drive));

            string messageSplit = "HelloWorld How are you?";

            messageSplit.Split(" ");

            Console.WriteLine(messageSplit);

        }

        /// <summary>
        /// Just testing out a comment in XML.
        /// </summary>
        static void Main(string[] args)
        {
            //Variables();
            //MinMax();
            //Operators();
            Strings();
        }
    }
}
