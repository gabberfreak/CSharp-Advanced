using System;
using System.Collections.Generic;
using System.Linq;


class BubbleSort
{
    static void Main(string[] args)
    {
        string[] nums = Console.ReadLine().Split(' ');

        int[] numbers = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            numbers[i] = int.Parse(nums[i]);
        }
        int index = 0;
        bool swapped = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            index = numbers[i];
            for (int j = i + 1; j < numbers.Length; j++,i++)
            {
                index = numbers[i];
                if (numbers[j] < numbers[i])
                {
                    numbers[i] = numbers[j];
                    numbers[j] = index;
                    swapped = true;
                }
            }
            if (swapped)
            {
                i = -1;
            }
            swapped = false;
        }
        Console.WriteLine(string.Join(" ", numbers));
        
    }
}
