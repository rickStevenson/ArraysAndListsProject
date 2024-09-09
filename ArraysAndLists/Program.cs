using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            
            foreach (int i in nums)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }

            
            Console.WriteLine("Even Numbers:");
            foreach (int i in evens)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("Odd Numbers:");
            foreach (int i in odds)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}
