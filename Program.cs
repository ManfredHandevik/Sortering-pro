using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Random rnd = new Random();

        for (int i = 0; i < 10000; i++)
        {
            numbers.Add(rnd.Next(0, 100000));
        }

        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            for (int j = 0; j < numbers.Count - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
        sw.Stop();

        Console.WriteLine("Sorterade tal:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine($"\nTid för sortering: {sw.ElapsedMilliseconds} ms");
        Console.WriteLine($"Tid för sortering: {sw.ElapsedTicks} ticks");
    }
}
