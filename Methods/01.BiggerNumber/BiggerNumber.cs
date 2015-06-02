using System;


class BiggerNumber
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);
    }

    static int GetMax(int num1, int num2)
    {
        int max = 0;
        if (num1 > num2)
        {
            max = num1;
        }
        else {
            max = num2;
        }
        return max;
    }
}