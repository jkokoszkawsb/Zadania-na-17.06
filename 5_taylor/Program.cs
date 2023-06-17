using System;

class Program
{
    static double CalculateExponential(double x, int n)
    {
        double result = 1.0; // Inicjalizacja sumy szeregu z pierwszym wyrazem

        for (int i = 1; i <= n; i++)
        {
            double term = Math.Pow(x, i) / Factorial(i); // Wyliczenie kolejnego wyrazu szeregu
            result += term; // Dodanie wyrazu do sumy
        }

        return result;
    }

    static double Factorial(int n)
    {
        if (n <= 1)
            return 1;

        double result = 1;

        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Podaj wartość x: ");
        double x = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj liczbę wyrazów n :");
        int n = int.Parse(Console.ReadLine());

        double approximation = CalculateExponential(x, n);
        Console.WriteLine("Wyliczona wartość e ^ " + x + " dla n = " + n + " wynosi: " + approximation);
    }
}
