using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double DD, T, VC = 0, VT = 0;
        char escolha = 'S';

        while (escolha == 'S' || escolha == 's')
        {
            Console.WriteLine("Digite o valor da compra: ");
            if (!double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out VC) || VC < 0)
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
                continue;
            }
            else{
            VT += VC;

            Console.WriteLine("Você continuará comprando (para sim, digite S)? ");
            escolha = Console.ReadLine()![0];
            }
        }

        Console.Write("Quanto foi dado ao caixa? R$");
        bool sucess = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out DD);
        if (!sucess || DD < 0)
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
            return;
        }

        T = DD - VT;

        if (T >= 0)
        {
            Console.WriteLine($"O valor da compra foi de R${VT.ToString("F2", CultureInfo.InvariantCulture)} e seu troco foi de R${T.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else
        {
            T = T * -1;
            Console.WriteLine($"O valor da compra foi R${VT.ToString("F2", CultureInfo.InvariantCulture)} e você deve R${T.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
