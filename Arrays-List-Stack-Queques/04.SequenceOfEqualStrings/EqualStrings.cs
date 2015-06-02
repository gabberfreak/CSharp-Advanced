using System;
using System.Collections.Generic;
using System.Linq;



class EqualStrings
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            Console.Write(words[i]);
            for (int j = i + 1; j < words.Length; j++)
                if (words[i] == words[j])
                {
                    Console.Write(" " + words[j]);
                    i++;
                }
            Console.WriteLine();
        }
    }
} 
