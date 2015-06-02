using System;
using System.Collections.Generic;
using System.Linq;

class FirstNeighbours
{
    static void Main(string[] args)
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1};

        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
    }

    static int GetIndexOfFirstElementLargerThanNeighbours(int[] nums)
    {
        int result = -1;
        bool larger = false;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                larger = nums[i] > nums[i + 1];
                if (larger)
                {
                    return result = 0;
                }
            }
            else if (i > 0 && i < nums.Length - 1)
            {
                larger = nums[i] > nums[i - 1] && nums[i] > nums[i + 1];
                if (larger)
                {
                    return result = i;
                }
            }
            else
            {
                larger = nums[i] > nums[i - 1];
                if (larger)
                {
                    return result = i;
                }
            }
        }
        return result;
    }
}
