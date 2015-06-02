using System;
using System.Linq;
using System.Collections.Generic;

class Categorize
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split(' ');

        List<int> roundNums = new List<int>();
        List<double> floatNums = new List<double>();
        

        for (int i = 0; i < numbers.Length; i++)
        {
            double curr = double.Parse(numbers[i]);
            if (curr % 1 == 0)
            {
                roundNums.Add(Convert.ToInt32(curr));
            }
            else
            {
                floatNums.Add(curr);
            }

        }
        string str1 = string.Join(", ", roundNums);
        string str2 = string.Join(", ", floatNums);

        int min1 = roundNums.Min();
        int max1 = roundNums.Max();
        int sum1 = roundNums.Sum();
        double avg1 = roundNums.Average();

        double min2 = floatNums.Min();
        double max2 = floatNums.Max();
        double sum2 = floatNums.Sum();
        double avg2 = floatNums.Average();

        Console.WriteLine();
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}\n", str2, min2, max2, sum2, avg2);
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", str1 ,min1 ,max1 ,sum1 ,avg1);
    }
}