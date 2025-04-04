using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        string nome = ObterNomeFuncionario();
        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("O nome não pode estar vazio ou ser um número.");
            return;
        }

        double salario = ObterValor("Digite o salário fixo do funcionário: ");
        double vendas = ObterValor("Quanto que ele vendeu? ");

        if (salario >= 0 && vendas >= 0)
        {
            double salarioFinal = CalcularSalarioFinal(salario, vendas);
            Console.WriteLine($"O funcionário {nome} tem um salário fixo de R${salario:F2}. Mas, tendo em vista que ele vendeu, em Reais, R${vendas:F2}, e que o funcionário tem 15% de comissão das vendas, seu salário final será de R${salarioFinal:F2}.");
        }
        else
        {
            Console.WriteLine("Verifique se os dados do salário e das vendas estão válidos.");
        }
        Console.ReadLine();
    }

    static string ObterNomeFuncionario()
    {
        Console.Write("Digite o nome do funcionário: ");
        string nome = Console.ReadLine()!;
        if (string.IsNullOrEmpty(nome) || double.TryParse(nome, out _) || nome.Any(char.IsDigit))
        {