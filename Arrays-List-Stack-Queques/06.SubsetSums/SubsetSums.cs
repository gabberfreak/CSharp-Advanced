using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSums
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] nums = Console.ReadLine().Split(' ');
        int[] array = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            array[i] = int.Parse(nums[i]);
        }
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                //TODO
            }
        }
    }
}