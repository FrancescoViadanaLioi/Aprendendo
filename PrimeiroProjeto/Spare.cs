using System.Globalization;

class Program
{
    static void Main()
    {
        int d;
        Console.Write("Digite o dinheiro possuído: ");
        bool sucess = int.TryParse(Console.ReadLine(), out d);

        if (sucess && d > 0)
        {
            int cem = d / 100;
            int cin = (d % 100) /50;
            int vin = ((d % 100) % 50) / 20;
            int dez = (((d % 100) % 50) % 20) / 10;
            int cinc = ((((d % 100) % 50) % 20) % 10) / 5;
            int dois = (((((d % 100) % 50) % 20) % 10) % 5) / 2;
            int um = ((((((d % 100) % 50) % 20) % 10) % 5) % 2) / 1;

            Console.WriteLine($"Com R${d} você pode ter: ");
            Console.WriteLine($"{cem} notas de R$100,00");
            Console.WriteLine($"{cin} notas de R$50,00");
            Console.WriteLine($"{vin} notas de R$20,00");
            Console.WriteLine($"{dez} notas de R$10,00");
            Console.WriteLine($"{cinc} notas de R$5,00");
            Console.WriteLine($"{dois} notas de R$2,00");
            Console.WriteLine($"{um} notas de R$1,00");
        }
        else
        {
            Console.WriteLine("Valor inválido. Verifique se você forneceu um número inteiro positivo.");
        }
        Console.ReadLine();
    }
}
