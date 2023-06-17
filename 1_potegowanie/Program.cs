// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Main()
    {
        int a, b, wynik = 1;
        Console.WriteLine("Podaj wartość podstawy");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość wykładnika");
        b = int.Parse(Console.ReadLine());

        while (b > 0)
        {
            wynik *= a;
            b--;
        }

        Console.WriteLine("Wynik powyższego działania do potęgi to " + wynik);
    }
}