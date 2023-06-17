// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pary liczb naturalnych o sumie równiej {0}:", n);
        FindNumberPairs(n);

        Console.ReadLine();
    }

    static void FindNumberPairs(int n)
    {
        for (int i = 1; i <= n / 2; i++)
        {
            int j = n - i;
            Console.WriteLine("{0} + {1} = {2}", i, j, n);
        }
    }
}
