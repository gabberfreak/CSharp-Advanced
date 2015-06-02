using System;
using System.Collections.Generic;
using System.Linq;

class IncreasingSequence
{
    static void Main(string[] args)
    {
        string[] nums = Console.ReadLine().Split(' ');
        int[] numbers = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            numbers[i] = int.Parse(nums[i]);
        }

        int sequenceCount = 1;
        int maxSequence = 1;
        int index = 0;

        Console.Write(numbers[0]);

        for (int j = 1; j < numbers.Length; j++)
        {
            if (numbers[j] > numbers[j - 1])
            {
                sequenceCount++;
                Console.Write(" " + numbers[j]);
            }
            else
            {
                sequenceCount = 1;

                Console.WriteLine();
                Console.Write(numbers[j]);
            }

            if (sequenceCount > maxSequence)
            {
                maxSequence = sequenceCount;
                index = j;
            }
        }
        Console.WriteLine();
        Console.Write("Longest:");

        for (int i = 0; i < maxSequence; i++)
        {
            Console.Write(" " + nums[index - maxSequence + 1 + i]);
        }
        Console.WriteLine();
    }
}
