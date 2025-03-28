using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double N1, N2, NF;

        Console.Write("Digite a nota do primeiro semestre: ");

        if (!double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out N1) || N1 < 0 || N1 > 50)
        {
            Console.WriteLine("Valor inválido, favor redigitar.");
            return;
        }

        else
        {
            Console.WriteLine("Digite a nota do segundo semestre: ");
        }
        if (!double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out N2) || N2 < 0 || N2 > 50)
        {
            Console.WriteLine("Valor inválido, favor redigitar.");
            return;
        }

        else
        {
            NF = N1 + N2;

            if (NF > 70)
            {
                Console.WriteLine($"Sua nota foi de {NF.ToString("F2", CultureInfo.InvariantCulture)}\nVocê foi aprovado!!!!!");
            }

            else if (NF < 70)
            {
                Console.WriteLine($"Sua nota foi de {NF.ToString("F2", CultureInfo.InvariantCulture)}\nVocê foi reprovado.");
            }

            Console.ReadLine();
        }

    }
}

