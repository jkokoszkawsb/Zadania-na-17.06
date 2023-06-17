// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        int lowerBound = 1;
        int upperBound = 20;

        Console.WriteLine("Wybierz liczbę z przedziału od 1 do 20, a ja ją zgadnę!");

        while (true)
        {
            int guess = (lowerBound + upperBound) / 2;
            Console.WriteLine($"Czy twoja liczba to {guess}?        ODPOWIEDZ: -1 - Moja mniejsza, 1 - Moja większa, 0 - Zgadłeś mądralo");

            int response = GetUserResponse();

            if (response == 0)
            {
                Console.WriteLine("Brawo! Zgadłem liczbę.");
                break;
            }
            else if (response < 0)
            {
                upperBound = guess - 1;
            }
            else
            {
                lowerBound = guess + 1;
            }
        }

        Console.ReadLine();
    }

    static int GetUserResponse()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int response))
            {
                return response;
            }
            else
            {
                Console.WriteLine("Podaj poprawną odpowiedź: -1 dla mniejszej liczby, 1 dla większej, 0 dla zgadnięcia.");
            }
        }
    }
}
