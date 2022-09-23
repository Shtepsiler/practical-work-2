using System;

internal class Program
{
    static void Main()
    {
 
        Console.WriteLine("write wourd");
        string first;

        first = Console.ReadLine();

    for(int i = 0; i < first.Length; i++)
        {
            Console.WriteLine($"{first[i]} -> {first[i] - 97}");

        }

     




    }
}
