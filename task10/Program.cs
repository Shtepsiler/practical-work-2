using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Write n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("write array");
        string first;

        first = Console.ReadLine();

        char[] separators = new char[] { ' ' };

        string[] subs = first.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[n]; int h = 0;
        foreach (var sub in subs)
        {
            numbers[h] = int.Parse(sub);
            h++;
        }
        Console.WriteLine("Write difference");
        int diff = int.Parse(Console.ReadLine());

        bool hasEqualSum = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            int leftSum = numbers.Take(i).Sum();
            int rightSum = numbers.Skip(i + 1).Sum();

            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                hasEqualSum = true;
                break;
            }
        }

        if (!hasEqualSum)
        {
            Console.WriteLine("no");
        }
    }
}