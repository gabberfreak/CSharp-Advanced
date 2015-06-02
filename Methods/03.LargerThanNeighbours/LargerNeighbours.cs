using System;
using System.Collections.Generic;
using System.Linq;

class LargerNeighbours
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers,i));
        }
    }

    static bool IsLargerThanNeighbours(int[] nums, int index)
    {
        bool isLarger = false;

        if (index == 0)
        {
            isLarger = nums[index] > nums[index + 1];
        }
        else if (index > 0 && index < nums.Length - 1)
        {
            isLarger = nums[index] > nums[index - 1] && nums[index] > nums[index + 1]; 
        }
        else
        {
            isLarger = nums[index] > nums[index - 1];
        }
        return isLarger;
    }
}