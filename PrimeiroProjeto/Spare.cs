using System;
using System.Globalization;

class Program
{
    public static void Main()
    {
        float NI;
        string intervalo;

        Console.Write("Digite um número: ");
        bool sucesso = float.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out NI);

        if (!sucesso)
        {
            Console.WriteLine("Valor inválido");
            return;
        }
        else if (NI >= 0.00f && NI <= 25.00f)
        {
            intervalo = "está no intervalo [0;25]";
        }
        else if (NI > 25.00f && NI <= 50.00f)
        {
            intervalo = "está no intervalo ]25;50]";
        }
        else if (NI > 50.00f && NI <= 100.00f)
        {
            intervalo = "está no intervalo ]50;100]";
        }
        else
        {
            intervalo = "está fora do intervalo";
        }

            Console.WriteLine($"O número {NI.ToString(CultureInfo.InvariantCulture)} {intervalo}.");
            Console.ReadLine();
    }
}

