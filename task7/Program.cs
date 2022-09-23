using System;
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

        int maxcoun = 1, count = 1;
        int k1 = 1, k2 = 1;

        for (int j = 0; j < (numbers.Length-1); j++)
        { 
            if (numbers[j]+1 == numbers[j+1])
            {
                count++;

                if (j == (numbers.Length - 2) && count != numbers.Length)
                {
                    if (maxcoun < count)
                   {
                        k2 = j + 2;
                        maxcoun = count + 1;
                        k1 = k2 - maxcoun;
                        count = 0;
                    }
                }
                else
                if(j == (numbers.Length - 2) && count == numbers.Length)
                {
                    k2 = j + 2;
                    maxcoun = count;
                    k1 = k2 - maxcoun;
                    count = 0;
                }
            }
            else
            {
                if (maxcoun < count)
                {
                    k2 = j+1;
                    maxcoun = count;
                    k1 = k2 - maxcoun ;
                    count = 0;
                }       
            }
        }
        for (int j = k1; j < k2; j++)
        {
            Console.Write($"{numbers[j]} ");

        }

    }
}
