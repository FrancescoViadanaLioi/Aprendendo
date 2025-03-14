using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome do funcionário: ");
        string nome = Console.ReadLine()!;
        if (String.IsNullOrEmpty(nome) || double.TryParse(nome, out _) || nome.Any(char.IsDigit))
        {
            Console.WriteLine("O nome não pode estar vazio ou ser um número.");
            return;
        }

        Console.Write("Digite o salário fixo do funcionário: ");
        bool sucesso2 = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double salario);

        Console.Write("Quanto que ele vendeu? ");
        bool sucesso3 = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double vendas);

        if (sucesso2 && sucesso3)
        {
            Console.WriteLine($"O funcionário {nome} tem um salário fixo de R${salario:F2}. Mas, tendo em vista que ele vendeu, em Reais, R${vendas:F2}, e que o funcionário tem 15% de comissão das vendas, seu salário final será de R${salario+vendas * 0.15:F2}.");
        }
        else
        {
            Console.WriteLine("Verifique se os dados do salário e das vendas estão válidos.");
        }
        Console.ReadLine();
    }
}

