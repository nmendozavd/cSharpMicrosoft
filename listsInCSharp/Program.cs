using System;
using System.Collections.Generic;

namespace listsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithStrings();
            FiboNums();
            
        }
        
        static void FiboNums()
        {
            // create list of ints with first 2 fibo nums
            var fiboNums = new List<int> { 1, 1 };
            // loop until the 20th num
            for (var i = 2; i < 20; i++)
            {
                // get prev for fibo nums
                var prev = fiboNums[fiboNums.Count - 1];
                var prev2 = fiboNums[fiboNums.Count - 2];
                // add next num to list
                fiboNums.Add(prev + prev2);
            }
            // loop through each index
            foreach (var nums in fiboNums)
            {
                Console.WriteLine(nums);
            }
        }
        
        static void WorkingWithStrings() 
        {
            var names = new List<string> { "Noel", "Ana", "Felipe" };
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[3]} and {names[2]} to the list");

            Console.WriteLine($"The list has {names.Count} people in it");

            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns { index } ");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is located at index {index}");
            }

            index = names.IndexOf("Not found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns { index } ");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is located at index {index}");
            }
        }
    }
}
