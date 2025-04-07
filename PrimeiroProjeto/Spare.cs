using System.Globalization;

class Program
{
    static void Main()
    {
        int HI, HF, duracao;

        Console.Write("Digite o horário de início e do horário de fim do evento (separados por espaço) ");
        string[] vet = Console.ReadLine()!.Split(' ');

        if (vet.Length != 2)
        {
            Console.WriteLine("Valores inválidos.");
        }
        else
        {
            bool sucesso1 = int.TryParse(vet[0], out HI);
            bool sucesso2 = int.TryParse(vet[1], out HF);

            if (sucesso1 && sucesso2 || HI <= 23 || HI >= 0 || HF <= 23 || HF >= 0)
            {
                if (HI < HF)
                {
                    duracao = HF - HI;
                    Console.WriteLine($"O jogo durou {duracao} horas");
                }
                else
                {
                    duracao = 24 - HI + HF;
                    Console.WriteLine($"O jogo durou {duracao} horas");
                }
            }
            else
            {

            }
        }
            Console.ReadLine();
    }
}