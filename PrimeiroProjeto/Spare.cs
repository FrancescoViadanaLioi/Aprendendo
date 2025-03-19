using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Quantos quilômetros você rodou? ");
        bool sucesso1 = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double kmRodados);

        if (!sucesso1 || kmRodados <= 0)
        {
            Console.WriteLine("Favor, verifique se o valor digitado é válido e maior do que 0.");
        }
        else if (sucesso1) // Verifica a entrada do segundo valor apenas se o primeiro foi válido
        {
            Console.Write("Quantos litros de combustível você consumiu? ");
            bool sucesso2 = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double litrosConsumidos);

            if (!sucesso2 || litrosConsumidos <= 0)
            {
                Console.WriteLine("Favor, verifique se o valor digitado é válido e maior do que 0.");
            }
            else
            {
                double consumoMedio = kmRodados / litrosConsumidos;
                Console.WriteLine($"Seu consumo médio é de {consumoMedio.ToString("F2", CultureInfo.InvariantCulture)}km/l.");
            }
        }
        Console.ReadLine();
    }
}
