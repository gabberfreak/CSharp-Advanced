using System;
using System.Collections.Generic;
using System.Linq;

class LastDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetLastDigitAsWord(512));
        Console.WriteLine(GetLastDigitAsWord(1024));
        Console.WriteLine(GetLastDigitAsWord(12309));
    }
    static string GetLastDigitAsWord(int num)
    {
        int lastDigit = num % 10;
        string[] words = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        return words[lastDigit];
    }
}
