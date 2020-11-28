using System;
using System.Collections.Generic;


namespace exercises1
{

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public enum Season
    {
        Spring = 10,
        Summer = 20,
        Winter = 30,
        Autumn = 40
    }

    public struct Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    
    class Program
    {   

        static void Arguments(int direction, bool option, int num = 0)
        {
            
            
        }
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

            string messageSplit = "Hello World How are you?";

            messageSplit.Split(" ");

            // Console.WriteLine(messageSplit);

           // Console.WriteLine("Just testing token here: {0}", messageSplit);

            double d = 23.123;

            //Console.WriteLine(Math.Round(d, 2));

            bool a = true;

            int b = 5;

            char c = 'c';

            string a1 = a.ToString();

            string b1 = b.ToString();

            string c1 = c.ToString();

            string d1 = d.ToString();

            //Console.WriteLine($"These are now strings: {a1}, {b1}, {c1}, {d1}");

            bool e = bool.Parse(a1);

            int h = int.Parse(b1);

            double g = double.Parse(d1);

            char f = char.Parse(c1);

            //Console.WriteLine($"Used Parse methods to initialize: {e}, {h}, {g}, {f}");

            // ENUM
            Season enumTest = (Season)20;

            // Console.WriteLine($" Season: {enumTest}, value: {(int)enumTest}");

            var p1 = new Person("Noel Menodza", 30);
            var p2 = new Person("Joe Smith", 50);

            // p1.Name = p2.Name;
            // p1.Age = p2.Age;

            Console.WriteLine("{0}, {1}", p1.Name, p1.Age);
            Console.WriteLine("{0}, {1}", p2.Name, p2.Age);
            
        }

        static void ConsoleProgram()
        {
            string firstName;
            string middleName;
            string lastName;

            Console.WriteLine("Enter your First Name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter your Middle Name: ");
            middleName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name: ");
            lastName = Console.ReadLine();
            
            // print values entered
            Console.WriteLine("{0} {1} {2}", firstName, middleName, lastName);
            
            Console.WriteLine("Press any key to exit...");
            // exit on key press
            Console.ReadKey();

        }

        /// <summary>
        /// Just testing out a comment in XML.
        /// </summary>
        static void Main(string[] args)
        {
            //Variables();
            //MinMax();
            //Operators();
            //Strings();
            //ConsoleProgram();
            // Arguments((Direction)0, true, 5);
        }
    }
}
