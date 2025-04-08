using System;
using System.Globalization;

class Program
{
    public static void Main()
    {
        float n1, n2, n3, n4, media;

        Console.Write("Digite as 4 notas separadas por espaço (use ponto como separador decimal): ");
        string[] vet = Console.ReadLine()!.Split(' ');

        if (vet.Length != 4)
        {
            Console.WriteLine("ERRO! Digite somente 4 números positivos separados por espaço.");
            return;
        }

        bool sucesso1 = float.TryParse(vet[0], CultureInfo.InvariantCulture, out n1);
        bool sucesso2 = float.TryParse(vet[1], CultureInfo.InvariantCulture, out n2);
        bool sucesso3 = float.TryParse(vet[2], CultureInfo.InvariantCulture, out n3);
        bool sucesso4 = float.TryParse(vet[3], CultureInfo.InvariantCulture, out n4);

        if (!sucesso1 || !sucesso2 || !sucesso3 || !sucesso4)
        {
            Console.WriteLine("Dados inválidos, favor redigitar.");
            return;
        }

        media = ((2 * n1) + (3 * n2) + (4 * n3) + (1 * n4)) / (2 + 3 + 4 + 1);

        Console.WriteLine($"Média: {media.ToString("F2", CultureInfo.InvariantCulture)}");

        if (media >= 7.0f)
        {
            Console.WriteLine("Você foi APROVADO.");
        }
        else if (media < 5.0f)
        {
            Console.WriteLine("Você foi REPROVADO.");
        }
        else
        {
            Console.Write("Digite a nota do exame extra: ");
            bool sucesso5 = float.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out float ne);

            if (!sucesso5)
            {
                Console.WriteLine("Nota inválida.");
                return;
            }

            media = (media + ne) / 2;
            Console.WriteLine($"Nova média: {media.ToString("F2", CultureInfo.InvariantCulture)}");

            if (media >= 5.0f)
            {
                Console.WriteLine("Você foi APROVADO após o exame.");
            }
            else
            {
                Console.WriteLine("Você foi REPROVADO após o exame.");
            }
        }

        Console.ReadLine();
    }
}
