using System;
using System.Collections.Generic;
using System.Linq;


class Lists
{
    static void Main(string[] args)
    {
        string[] numbers1 = Console.ReadLine().Split(' ');
        string[] numbers2 = Console.ReadLine().Split(' ');

        int[] nums1 = new int[numbers1.Length];
        int[] nums2 = new int[numbers2.Length];

        for (int i = 0; i < numbers1.Length; i++)
        {
            nums1[i] = int.Parse(numbers1[i]);
        }

        for (int i = 0; i < numbers2.Length; i++)
        {
            nums2[i] = int.Parse(numbers2[i]);
        }

        List<int> joins = new List<int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            if (joins.Contains(nums1[i]))
            {
                continue;
            }
            else
            {
                joins.Add(nums1[i]);
            }
        }
        for (int j = 0; j < nums2.Length; j++)
        {
            if (joins.Contains(nums2[j]))
            {
                continue;
            }
            else
            {
                joins.Add(nums2[j]);
            }
        }
        joins.Sort();
        Console.WriteLine(string.Join(" ", joins));
    }
}