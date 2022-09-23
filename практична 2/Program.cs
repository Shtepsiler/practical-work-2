using System;


    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("write length of the first array");
            int n =int.Parse(Console.ReadLine());
            Console.WriteLine("write first array");
            var first = new string[n] ;
            for (int i = 0; i < n; i++)
            {
                first[i] = Console.ReadLine();
            }


            Console.WriteLine("write length of the second array");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("write second array");
            var second = new string[m];
            for (int i = 0; i < m; i++)
            {
                second[i] = Console.ReadLine();
            }




            if (n >= m)
            {
                int rl = 0, ll = 0;
                if (first[0] == second[0])
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (first[j] == second[j])
                        {
                            ll++;
                        }

                    }
                    Console.WriteLine("The largest common end is at the left:");
                    for (int j = 0; j < ll; j++)
                    {
                        Console.WriteLine(first[j]);
                    }
                }
                else
                    if (second[m - 1] == first[n - 1])
                {
                    int l=n -1, k=m-1; 
                    while(first[l] == second[k])
                    {
                        rl++;
                        l--;
                        k--;
                    }

                    Console.WriteLine("The largest common end is at the right:");
                    for (int j = (n - rl); j < n; j++)
                    {
                        Console.WriteLine(first[j]);
                    }
                }
                else
                {
                    Console.WriteLine("No common words at the left and right");
                }
            }
            else
                if (m > n)
            {
                int rl = 0, ll = 0;
                if (first[0] == second[0])
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (first[j] == second[j])
                        {
                            ll++;
                        }

                    }
                    Console.WriteLine("The largest common end is at the left:");
                    for (int j = 0; j < ll; j++)
                    {
                        Console.WriteLine(second[j]);
                    }
                }
                else
                    if (second[m - 1] == first[n - 1])
                {

                    int l = n - 1, k = m - 1;
                    while (first[l] == second[k])
                    {
                        rl++;
                        l--;
                        k--;
                    }
                  
                    Console.WriteLine("The largest common end is at the right:");
                    for (int j = (m - rl); j < m; j++)
                    {
                        Console.WriteLine(second[j]);
                    }
                }
                else
                {
                    Console.WriteLine("No common words at the left and right");
                }
            }


        }
    }
