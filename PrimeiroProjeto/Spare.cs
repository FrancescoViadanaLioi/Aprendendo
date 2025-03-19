using System.Globalization;

class Program
{
    static void Main()
    {
        double x1, x2, y1, y2, d;
        Console.Write("Digite os valores de x1, x2, y1 e y2, respectivamente(separados por espaços, somente 4 entradas e somente números positivos): ");
        string[] vetor = Console.ReadLine()!.Split(' ');

        if
            (vetor.Length !=4 ||
                !double.TryParse(vetor[0], NumberStyles.Any, CultureInfo.InvariantCulture, out x1) ||
                !double.TryParse(vetor[1], NumberStyles.Any, CultureInfo.InvariantCulture, out x2) ||
                !double.TryParse(vetor[2], NumberStyles.Any, CultureInfo.InvariantCulture, out y1) ||
                !double.TryParse(vetor[3], NumberStyles.Any, CultureInfo.InvariantCulture, out y2))
        {
            Console.WriteLine("Digitação inválida. Favor verificar se há espaços, se há somente 4 entradas e se são números positivos.");
            return;
        }
        else
        {
            d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"A distância entre os pontos ({x1.ToString("F2",CultureInfo.InvariantCulture)};{y1.ToString("F2", CultureInfo.InvariantCulture)}) e");
            Console.Write($"({x2.ToString("F2", CultureInfo.InvariantCulture)};{y2.ToString("F2", CultureInfo.InvariantCulture)}) é de {d.ToString("F2", CultureInfo.InvariantCulture)}");
        }
            Console.ReadLine();
    }
}
