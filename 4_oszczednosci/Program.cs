using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj kwotę początkową: ");
        double kwotaPoczatkowa = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj oprocentowanie w skali roku: ");
        double oprocentowanie = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj liczbę miesięcy oszczędzania: ");
        int liczbaMiesiecy = int.Parse(Console.ReadLine());

        double oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
        double kwotaKoncowa = kwotaPoczatkowa * Math.Pow(1 + oprocentowanieMiesieczne, liczbaMiesiecy);
        double podatekBelki = 0.81; // Przykładowa stawka podatku Belki (19%)
        double kwotaZarobiona = kwotaKoncowa - kwotaPoczatkowa - (kwotaKoncowa - kwotaPoczatkowa) * podatekBelki;

        Console.WriteLine("Kwota zarobiona: " + kwotaZarobiona);
    }
}
