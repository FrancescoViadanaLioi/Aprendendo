using System;
using System.Globalization;
partial class Program
{
    static void Main(string[] args)
    {
        double conta;
        int minutos;

        conta = 50.0;
        Console.Write("Digite a quantidade de minutos de uso do telefone: ");
        bool sucess = int.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out minutos);

        if (!sucess || minutos < 0)
        {
            Console.WriteLine("Valor inválido. Favor verificar se há somente números inteiros positivos na entrada de dados.");
            return;
        }
        else if (minutos > 100)
        {
            conta = conta + (minutos - 100) * 2.0;
        }
        Console.WriteLine($"O valor a pagar será de R${conta.ToString("F2", CultureInfo.InvariantCulture)}.");
        Console.ReadLine();
    }
}