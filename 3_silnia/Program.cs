using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę n (większą lub równą 5): ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj liczbę k (większą lub równą 5): ");
        int k = int.Parse(Console.ReadLine());

        if (n < 5 || k < 5)
        {
            Console.WriteLine("Liczby muszą być większe lub równe 5.");
            return;
        }

       

        // Obliczanie wartości n!
        long nFactorial = CalculateFactorial(n);

        // Obliczanie wartości k!
        long kFactorial = CalculateFactorial(k);

        // Obliczanie wartości m=(n!-k!)/k!
        double m = (nFactorial - kFactorial) / (double)kFactorial;

        Console.WriteLine($"Wynik: {m}");
    }

    // Funkcja do obliczania silni
    static long CalculateFactorial(int number)
    {
        long factorial = 1;

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
