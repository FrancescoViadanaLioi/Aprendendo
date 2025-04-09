using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine()!;

        if (string.IsNullOrWhiteSpace(nome) || double.TryParse(nome, out _) || nome.Any(char.IsDigit))
        {
            Console.WriteLine("Nome inválido, tente novamente.");
            return;
        }

        Console.Write("Quantos anos você tem? ");
        if (!int.TryParse(Console.ReadLine(), out int idade) || idade < 10 || idade > 120)
        {
            Console.WriteLine("ACESSO NEGADO! Verifique se a idade inserida é válida ou se está entre 10 a 120 anos.");
            return;
        }

        Console.Write("Digite a altura e peso separados por espaço: ");
        string[] vet = Console.ReadLine()!.Split(' ');

        if (vet.Length != 2 ||
            !double.TryParse(vet[0], CultureInfo.InvariantCulture, out double altura) ||
            !int.TryParse(vet[1], CultureInfo.InvariantCulture, out int peso) ||
            altura < 1.00 || altura >= 2.50 || peso <= 0 || peso >= 300)
        {
            Console.WriteLine("Favor inserir dados válidos.");
            return;
        }

        Console.WriteLine($"Olá, {nome}, você tem {idade} anos, tem {altura.ToString("F2", CultureInfo.InvariantCulture)} e pesa {peso}KG.");
        Console.ReadLine();
    }
}
