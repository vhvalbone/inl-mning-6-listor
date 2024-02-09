using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in namn på matvaror:");
        string[] matvaror = Console.ReadLine().Split();

        Console.WriteLine("Skriv in matvarornas priser:");
        int[] priser = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine("Skriv in din handlingslista:");
        string[] handlingslista = Console.ReadLine().Split();

        int totalKostnad = BeräknaKostnad(matvaror, priser, handlingslista);
        Console.WriteLine($"Priset för handlingslistan är {totalKostnad}");
    }

    static int BeräknaKostnad(string[] matvaror, int[] priser, string[] handlingslista)
    {
        Dictionary<string, int> produktTillPris = new Dictionary<string, int>();

        for (int i = 0; i < matvaror.Length; i++)
        {
            produktTillPris[matvaror[i]] = priser[i];
        }

        int totalKostnad = 0;
        foreach (string produkt in handlingslista)
        {
            if (produktTillPris.ContainsKey(produkt))
            {
                totalKostnad += produktTillPris[produkt];
            }
        }

        return totalKostnad;
    }
}

