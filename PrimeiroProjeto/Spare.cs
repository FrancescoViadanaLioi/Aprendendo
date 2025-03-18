using System.Globalization;

class Program
{
    static void Main()
    {
        double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

        Console.Write("Digite os valores de A, B e C (separados por espaços, todos devem ser números positivos): ");
        string[] valores = Console.ReadLine()!.Split(' ');

        // Validação para garantir que os valores sejam válidos
        if (valores.Length != 3 ||
            !double.TryParse(valores[0], NumberStyles.Float, CultureInfo.InvariantCulture, out A) || A <= 0 ||
            !double.TryParse(valores[1], NumberStyles.Float, CultureInfo.InvariantCulture, out B) || B <= 0 ||
            !double.TryParse(valores[2], NumberStyles.Float, CultureInfo.InvariantCulture, out C) || C <= 0)
        {
            Console.WriteLine("Erro: Certifique-se de digitar exatamente 3 números positivos separados por espaços.");
            return;
        }

        // Cálculos
        triangulo = A * C / 2;
        circulo = Math.PI * C * C;
        trapezio = (A + B) / 2 * C;
        quadrado = B * B;
        retangulo = A * B;

        // Resultados formatados
        Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}
