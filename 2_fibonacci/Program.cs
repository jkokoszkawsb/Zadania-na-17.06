using System;

public class Fibonacci
{
    public static void Main()
    {
        Console.WriteLine("Podaj liczbę wyrazów ciągu Fibonacciego do wygenerowania:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ciąg Fibonacciego:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(GenerateFibonacci(i));
        }
    }

    public static int GenerateFibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return GenerateFibonacci(n - 1) + GenerateFibonacci(n - 2);
        }
    }
}
