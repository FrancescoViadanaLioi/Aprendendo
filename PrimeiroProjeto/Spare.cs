using System;
using System.Globalization;
using System.Linq;
partial class Program
{
    static void Main()
    {
        int x, y, z;

        Console.WriteLine("Digite três números inteiros separados por espaço: ");
        String[] vet = Console.ReadLine()!.Split(' ');

        if (vet.Length == 3 && vet.All(item => int.TryParse(item, out _)))
        {
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                Console.WriteLine($"O menor valor é {x}.");
            }
            else if (y < x && y < z)
            {
                Console.WriteLine($"O menor valor é {y}.");
            }
            else
            {
                Console.WriteLine($"O menor valor é {z}.");
            }
        }
        else
        {
            Console.WriteLine("Erro: digite três números inteiros separados por espaço.");
        }
        Console.ReadLine();
    }
}
