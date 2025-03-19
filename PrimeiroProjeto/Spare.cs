using System.Globalization;

class Program
{
    static void Main()
    {
        double A, B, maior;
        Console.Write("Digite dois valores separados por espaço: ");
        string[] valores = Console.ReadLine()!.Split(' ');

        if
            (valores.Length !=2||!double.TryParse(valores[0], NumberStyles.Any, CultureInfo.InvariantCulture, out A) ||
            !double.TryParse(valores[1], NumberStyles.Any, CultureInfo.InvariantCulture, out B))
        {
            Console.WriteLine("Erro! Favor inserir 2 números. Espaços em branco e/ou carcteres não serão aceitos.");
            return;
        }
        else
        {
            maior = (A + B + Math.Abs(A - B)) / 2;
            Console.WriteLine($"O maior valor é {maior}");
        }
        Console.ReadLine();
    }
}
