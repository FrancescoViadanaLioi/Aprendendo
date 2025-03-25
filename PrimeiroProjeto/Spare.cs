using System;
using System.Globalization;

partial class Program
{
    static void Main()
    {
        int D1 = 0, H1 = 0, M1 = 0, S1 = 0, D2 = 0, H2 = 0, M2 = 0, S2 = 0, DF = 0, HF = 0, MF = 0, SF = 0,inicio, fim, duracao, resto;

        Console.Write("Digite a data, hora, minuto e segundo de início do evento(separados por espaços): ");
        string[] v = Console.ReadLine()!.Split(' ');

        if (!int.TryParse(v[0], out D1) || D1<=0 ||
            !int.TryParse(v[1], out H1) || H1<=0 || H1 >=24 ||
            !int.TryParse(v[2], out M1) || M1<=0 || M1 >=60 ||
            !int.TryParse(v[3], out S1) || S1<=0 || S1 >=60 ||
            v.Length != 4)
        {
            Console.WriteLine("Digitação inválida, favor verificar se há somente números inteiros positivos.");
        }
        else
        {
            Console.Write("Digite a data, hora, minuto e segundo de término do evento(separados por espaços): ");
            v = Console.ReadLine()!.Split(' ');

            if (!int.TryParse(v[0], out D2) || D2 <=0 ||
                !int.TryParse(v[1], out H2) || H2 <=0 || H2 >=24 ||
                !int.TryParse(v[2], out M2) || M2 <=0 || M2 >=60 ||
                !int.TryParse(v[3], out S2) || S2 <=0 || S2 >=60 ||
                v.Length !=4)
            {
                Console.WriteLine("Digitação inválida, favor verificar se há somente números inteiros positivos.");
            }
            else
            {
                inicio = (D1 - 1) * 24 * 60 * 60 + (H1 * 60 * 60) + (M1 * 60) + S1;
                fim = (D2 - 1) * (24 * 60 * 60) + (H2 * 60 * 60) + (M2 * 60) + S2;

                duracao = fim - inicio;

                DF = duracao / (24 * 60 * 60);
                resto = duracao % (24 * 60 * 60);
                HF = resto / (60 * 60);
                resto = resto % (60 * 60);
                MF = resto / 60;
                SF = resto % 60;

                Console.WriteLine($"{DF} dia(s)");
                Console.WriteLine($"{HF} hora(s)");
                Console.WriteLine($"{MF} minuto(s)");
                Console.WriteLine($"{SF} segundo(s)");
            }
        }

        Console.ReadLine();
    }
}
