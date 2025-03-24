class Program
{
    public static void Main()
    {
        Console.Write("Digite sua idade em dias: ");
        bool sucess1 = int.TryParse(Console.ReadLine(), out int dias);

        if (!sucess1 || dias <= 0)
        {
            Console.WriteLine("Favor, verificar se somente há um número inteiro positivo.");
            return;
        }
        else
        {
            int anos = dias / 365;
            int meses = (dias % 365) / 30;
            int dia = (dias % 365) % 30;

            Console.WriteLine($"Uma pessoa com {dias} tem {anos} ano(s), {meses} mês(es) e {dia} dia(s)");

        }
        Console.ReadLine();
    }
}
