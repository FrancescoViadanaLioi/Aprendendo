using System.ComponentModel.Design;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        int n1, n2;

        Console.Write("Digite dois números inteiros separados por espaço: ");
        string[] vet = Console.ReadLine()!.Split(' ');

        if (vet.Length != 2)
        {
            Console.WriteLine("Favor digitar somente dois números inteiros.");
            return;
        }
        else
        {
            bool sucesso1 = int.TryParse(vet[0], out n1);
            bool sucesso2 = int.TryParse(vet[1], out n2);

            if (sucesso1 && sucesso2)
            {
                if (n1 % n2 == 0 || n2 % n1 == 0)
                {
                    Console.WriteLine($"{n1} e {n2} são múltiplos.");
                }
                else
                {
                    Console.WriteLine($"{n1} e {n2} não são múltiplos.");
                }
            }
            else if (!sucesso1 || !sucesso2)
            {
                Console.WriteLine("Válores inválidos.");
                return;
            }
        }
        Console.ReadLine();
    }
}
