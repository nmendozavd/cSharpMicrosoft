using System;
using System.Collections.Generic;

namespace exercises2
{
    class Program
    {

        static void Conditionals()
        {
            // int x = 10;

            // if(x == 100)
            // {
            //     Console.WriteLine($"{x} is equal to 100");
            // }
            // else if(x < 100)
            // {
            //     Console.WriteLine($"{x} is less than 100");
            // }
            // else if(x > 100)
            // {
            //     Console.WriteLine($"{x} is greater than 100");
            // }

            string message = "helloworld";

            if(message.Length < 5 && message.Length % 2 == 1)
            {
                Console.WriteLine("String is less than 5 or odd");
            } 
            else if(message.Length >= 10 && message.Length % 2 == 0)
            {
                Console.WriteLine("String is greather than 10 and even");
            }

            if(message.Length < 5)
            {
                if(message.Length % 2 == 1)
                {
                    Console.WriteLine("Nested: String is less than 5 or odd");  
                }
            } 
            else if (message.Length >= 10) 
            {
                if(message.Length % 2 == 0)
                {
                    Console.WriteLine("Nested: String is greather than 10 and even");
                }
            }
        }

        static void Loops()
        {


            string numbers = "0123456789";
            string odd = "";

            //int j = 0;
            
            // while(j < numbers.Length)
            // {
            //     if (numbers[j] % 2 == 1)
            //     {
            //         odd += numbers[j];
            //     } 
            //     j++;
            // }
            // Console.WriteLine($"While: {odd}");
            
            // for(int i = 0; i < numbers.Length; i++)
            // {
            //     if(numbers[i] % 2 == 1)
            //     {
            //         odd += numbers[i];
            //     }
            // }
            //Console.WriteLine($"For Loop: {odd}");
            
            string[] numsArray = numbers.Split("");
            
            foreach(char letter in numbers)
            {
                if (letter % 2 == 1)
                {
                    odd += letter;
                }
                //Console.WriteLine(letter);
            }
            // Console.WriteLine($"For Each: {odd}");

            /*
            ---NESTED LOOPS --
            Imagine you have a hat with 5 different numbers in it. 
            You take out numbers, one at a time, without putting them back.

            Write code that prints out every possible combination of numbers you can get, 
            in all the different orders you can get them. Use any type of loops you want.

            */

            // int[] nums = {1 ,2, 3, 4, 5};
            // List<int> results = new List<int>();


            // for(int i = 0; i < nums.Length; i++) {
            //     for(int j = i + 1; j < nums.Length; j++) {
                
            //     }
            // }

            string s = "testing";

            for(int i = 1; i < s.Length; i++)
            {
                char letter = s[0];
                if(letter == s[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        static void Arrays()
        {
            int[] arr = new int[10];

            for(int i = 0; i < arr.Length; i++) 
            {
                arr[i] = i + 1;
            }

            int sum = 0;

            for(int i = arr.Length - 1; i >= 0; i--)
            {
                //Console.WriteLine(arr[i]);
                sum += arr[i];
            }

            // Console.WriteLine("[{0}]", string.Join(", ", arr));
            // Console.WriteLine(sum);

            foreach(int item in arr)
            {
                // Console.WriteLine(item);
            }

            int[,] array2D = new int[6, 4];

            string arrayString = "";

            for(int i = 0; i < array2D.GetLength(0); i++)
            {
                for(int j = 0; j < array2D.GetLength(1); j++)
                {
                    array2D[i, j] = i * j; 
                    arrayString += string.Format("{0} ", array2D[i, j]);
                }
                arrayString += System.Environment.NewLine + System.Environment.NewLine;
            }
            Console.WriteLine(arrayString);

            foreach(int index in array2D)
            {
                Console.WriteLine(index);
            }

        }
        static void Main(string[] args)
        {
            //Conditionals();
            //Loops();
            //Arrays();
        }
    }
}
 