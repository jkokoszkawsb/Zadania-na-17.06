// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę naturalną: ");
        int liczba = int.Parse(Console.ReadLine());

        if (liczba < 100)
        {
            Console.WriteLine("Podana liczba musi mieć przynajmniej 3 cyfry.");
        }
        else
        {
            Console.WriteLine("Cyfry liczby:");
            WypiszCyfry(liczba);
        }

        Console.ReadLine();
    }

    static void WypiszCyfry(int liczba)
    {
        string liczbaString = liczba.ToString();

        for (int i = 0; i < liczbaString.Length; i++)
        {
            Console.WriteLine(liczbaString[i]);
        }
    }
}
