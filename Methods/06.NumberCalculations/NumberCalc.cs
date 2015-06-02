using System;
using System.Collections.Generic;
using System.Linq;

class NumberCalc
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        double[] nums = new double[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = double.Parse(input[i]);
        }

        Console.Write("The minimum number is: {0}", GetMinNumberArray(nums));
        Console.WriteLine();
        Console.Write("The maximum number is: {0}", GetMaxNumberArray(nums));
        Console.WriteLine();
        Console.Write("The average number is: {0}", GetAverageNumberArray(nums));
        Console.WriteLine();
        Console.Write("Sum of the numbers is: {0}", GetSumNumberArray(nums));
        Console.WriteLine();
        Console.Write("The product of the numbers is: {0}", GetProductNumberArray(nums));
        Console.WriteLine();
    }
    static double GetMinNumberArray(double[] numbers)
    {
        double minNum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < minNum)
            {
                minNum = numbers[i];
            }
        }
        return minNum;
    }
    static decimal GetMinNumberArray(decimal[] numbers)
    {
        decimal minNum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < minNum)
            {
                minNum = numbers[i];
            }
        }
        return minNum;
    }
    static double GetMaxNumberArray(double[] numbers)
    {
        double maxNum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNum)
            {
                maxNum = numbers[i];
            }
        }
        return maxNum;
    }
    static decimal GetMaxNumberArray(decimal[] numbers)
    {
        decimal maxNum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNum)
            {
                maxNum = numbers[i];
            }
        }
        return maxNum;
    }
    static double GetAverageNumberArray(double[] numbers)
    {
        double sum = 0;
        int length = numbers.Length;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum / numbers.Length;
    }
    static decimal GetAverageNumberArray(decimal[] numbers)
    {
        decimal sum = 0;
        int length = numbers.Length;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum / numbers.Length;
    }
    static double GetSumNumberArray(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static decimal GetSumNumberArray(decimal[] numbers)
    {
        decimal sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static double GetProductNumberArray(double[] numbers)
    {
        double product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
    static decimal GetProductNumberArray(decimal[] numbers)
    {
        decimal product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}