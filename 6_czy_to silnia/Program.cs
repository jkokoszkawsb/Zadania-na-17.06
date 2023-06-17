// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Podaj liczbę x:");
        int x = int.Parse(Console.ReadLine());

        int n = FindFactorialNumber(x);

        if (n != -1)
        {
            Console.WriteLine("Liczba " + x + " jest silnią liczby " + n);
        }
        else
        {
            Console.WriteLine("Liczba " + x + " nie jest silnią żadnej liczby");
        }
    }

    public static int FindFactorialNumber(int x)
    {
        int n = 0;
        int factorial = 1;

        while (factorial <= x)
        {
            n++;
            factorial *= n;

            if (factorial == x)
            {
                return n;
            }
        }

        return -1;
    }
}
