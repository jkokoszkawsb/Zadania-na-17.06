// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę: ");
        int liczba = int.Parse(Console.ReadLine());

        int odwroconaLiczba = OdwrocLiczbe(liczba);

        Console.WriteLine("Odwrocona liczba: " + odwroconaLiczba);
    }

    static int OdwrocLiczbe(int liczba)
    {
        int odwroconaLiczba = 0;

        while (liczba != 0)
        {
            int cyfra = liczba % 10;
            odwroconaLiczba = (odwroconaLiczba * 10) + cyfra;
            liczba /= 10;
        }

        return odwroconaLiczba;
    }
}
