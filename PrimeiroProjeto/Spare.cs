using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double a, b, c, R1, R2, delta;

        Console.Write("Digite os valores de a, b e c para serem usados na fórmula de Bhaskara (separados por espaço): ");
        string[] vet = Console.ReadLine()!.Split(' ');

        if (vet.Length != 3)
        {
            Console.WriteLine("Entrada inválida. Digite os valores de a, b e c separados por espaço ou verifique se há somente 3 itens.");
            return;
        }

        else
        {
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);
            delta = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0 || delta <= 0)
            {
                Console.WriteLine("Impossível calcular. O delta não deve ser menor do que zero e/ou o a não deve ser igual a zero.");
                return;

            }
            else if (delta > 0)
            {
                R1 = (-b + Math.Sqrt(delta)) / (2 * a);
                R2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"Para a = {a.ToString(CultureInfo.InvariantCulture)}, b = {b.ToString(CultureInfo.InvariantCulture)} e c = {c.ToString(CultureInfo.InvariantCulture)}, as raízes são:\n R1 = {R1.ToString("F3", CultureInfo.InvariantCulture)} e R2 = {R2.ToString("F3", CultureInfo.InvariantCulture)}");
            }
        }
        Console.ReadLine();
    }
}