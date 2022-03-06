using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbersToBePushed = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> basicStack = new Stack<int>(numbersToBePushed);

            int numbersToPop = elements[1];
            int numberToLookFor = elements[2];
            for (int i = 0; i < numbersToPop; i++)
            {
                basicStack.Pop();
            }
            if (basicStack.Contains(numberToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (basicStack.Count > 0)
                {
                    Console.WriteLine(basicStack.Min());
                }
                else
                {
                    Console.WriteLine(basicStack.Count);
                }
            }
        }
    }
}
