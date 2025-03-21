using System.Globalization;

class Program
{
    static void Main()
    {
        int N;
        Console.Write("Escreva o número de segundos: ");
        bool sucess = int.TryParse(Console.ReadLine(), out N);

        if (!sucess || N < 0)
        {
            Console.WriteLine("Dados inválidos, favor redigitar um número inteiro positivo.");
        }
        else
        {
            int horas = N / 3600;
            int minutos = (N % 3600) / 60;
            int segundos = (N % 3600) % 60;
            Console.WriteLine($"Em {N} segundos, há {horas} horas, {minutos} minutos e {segundos} segundos. ");
        }
        Console.ReadLine();
    }
}
