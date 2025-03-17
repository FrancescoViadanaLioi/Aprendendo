using System;
using System.Globalization;

class Program
{
    static void Main()
    {
       Console.Write("Qual é o raio da esfera? ");
       bool sucesso1 = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double raio);

        if(!sucesso1 || raio<=0)
        {
            Console.WriteLine("Valor inválido. Por favor, inserir um número maior que zero.");
            return;
        }
        else
        {
            double vol = (4.0/3.0) * Math.PI * Math.Pow(raio, 3);
            Console.WriteLine($"O volume de uma esfera de raio {raio.ToString("F2", CultureInfo.InvariantCulture)} é de {vol.ToString("F2", CultureInfo.InvariantCulture)}. ");
        }
        Console.ReadLine();
    }
    }

