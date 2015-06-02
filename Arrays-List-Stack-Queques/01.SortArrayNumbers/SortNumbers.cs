using System;
using System.Linq;

class SortNumbers
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int[] nums = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            nums[i] = int.Parse(numbers[i]);
        }

        Array.Sort(nums);
        Console.WriteLine(string.Join(" ", nums));
    }
}
