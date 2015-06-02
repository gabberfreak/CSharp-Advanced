using System;
using System.Collections.Generic;
using System.Linq;

class ReverseNumber
{
    static void Main(string[] args)
    {
        double reversed = GetReversedNumber(123.45);
        Console.WriteLine(reversed);
    }

    static double GetReversedNumber(double num)
    {
        string reversed = new string(num.ToString().Reverse().ToArray());
        return double.Parse(reversed);
    }
}
