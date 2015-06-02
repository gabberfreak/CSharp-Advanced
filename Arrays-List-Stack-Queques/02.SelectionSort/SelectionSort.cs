using System;



class SelectionSort
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int[] nums = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            nums[i] = int.Parse(numbers[i]);
        }

        int index = 0;
        int smallest = int.MaxValue;
        bool found = false;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            int first = nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                int curr = nums[j];
                if ((curr > smallest) && (found == true))
                {
                    continue;
                }
                if (curr < first)
                {
                    found = true;
                    smallest = curr;
                    index = j;
                }
            }
            if (!found)
            {
                continue;
            }
            else
            {
                nums[i] = smallest;
                nums[index] = first;
                found = false;
            }
            
        }
        Console.WriteLine(string.Join(" ", nums));
    }
}