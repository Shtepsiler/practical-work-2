using System;

    internal class Program
    {
        static void Main(string[] args)
        {
    
        Console.WriteLine("write first array");
        string arrr1;

        arrr1 = Console.ReadLine();
        char[] arrrr1 = new char[256];


        char[] separators = new char[] { ' ' };

        string[] subs1 = arrr1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int i = 0;
        foreach (var sub in subs1)
        {
            arrrr1[i] = char.Parse(sub);
            i++;
        }
      /*  for(int d = 0; d < arrrr1.Length; d++)
        {
            Console.Write($"{arrrr1[d]}");
        }*/

        Console.WriteLine("write second array");
        string arrr;

        arrr = Console.ReadLine();
        char[] arrrr = new char[256];



        string[] subs = arrr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int j = 0;
        foreach (var sub in subs)
        {
            arrrr[j] = char.Parse(sub);
            j++;
        }
       /* for (int d = 0; d < arrrr.Length; d++)
        {
            Console.Write($"{arrrr[d]}");
        }*/


        if (arrr[0] < arrr1[0])
        {
            for (int d = 0; d < arrrr.Length; d++)
            {
                Console.Write($"{arrrr[d]}");
            }
            Console.WriteLine();
            for (int d = 0; d < arrrr1.Length; d++)
            {
                Console.Write($"{arrrr1[d]}");
            }
        }
        else
        {
            for (int d = 0; d < arrrr1.Length; d++)
            {
                Console.Write($"{arrrr1[d]}");
            }
            Console.WriteLine();
            for (int d = 0; d < arrrr.Length; d++)
            {
                Console.Write($"{arrrr[d]}");
            }


        }



    }
}

