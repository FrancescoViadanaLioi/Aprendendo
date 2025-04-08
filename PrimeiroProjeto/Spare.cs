using System;
using System.Globalization;

class Program
{
    public static void Main()
    {
        double salario = 0, reajuste = 0, salariof = 0;

        Console.Write("Qual é o seu salário? R$");
        bool sucesso1 = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out salario);

        if (!sucesso1 || salario <= 0)
        {
            Console.WriteLine("Valor inválido. Favor redigitar (somente números positivos são permitidos).");
            return;
        }
        else if (salario <= 400.00)
        {
            reajuste = 0.15;
            salariof = salario + salario * reajuste;
        }
        else if (salario > 400.00 && salario <= 800.00)
        {
            reajuste = 0.12;
            salariof = salario + salario * reajuste;
        }
        else if (salario > 800.00 && salario <= 1200.00)
        {
            reajuste = 0.10;
            salariof = salario + salario * reajuste;
        }
        else if (salario > 1200.00 && salario <= 2000.00)
        {
            reajuste = 0.07;
            salariof = salario + salario * reajuste;
        }
        else if (salario > 2000.00)
        {
            reajuste = 0.04;
            salariof = salario + salario * reajuste;
        }

        reajuste *= 100;

        Console.WriteLine($"O salário de R${salario.ToString("F2", CultureInfo.InvariantCulture)} com um reajuste de {reajuste.ToString("F1",CultureInfo.InvariantCulture)}% terá como salario final R${salariof.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.ReadLine();
    }
}

