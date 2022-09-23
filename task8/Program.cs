using System;
using System.Linq;
internal class Program
    {
        static void Main()
        {
        Console.WriteLine("Write n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("write array");
        string first;

        first = Console.ReadLine();

        char[] separators = new char[] { ' ' };

        string[] subs = first.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[n]; int i = 0;
        foreach (var sub in subs)
        {
            numbers[i] = int.Parse(sub);
            i++;
        }
        int maxcount = 0;
        int MFN = 0;

        foreach (var num in numbers)
        {
            int count = numbers.Count(x => x == num);
            if (count > maxcount)
            {
                maxcount = count;
                MFN = num;
            }
        }

        Console.WriteLine(MFN);


    }
    }
