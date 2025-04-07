using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int codigo, npedidos;
        double valor = 0, total = 0;
        char escolha = 's';

        while (escolha == 's' || escolha == 'S')
        {
            // Exibindo o menu de produtos
            Console.WriteLine("1 - Hot Dog \n2 - X-Salada \n3 - X-Bacon \n4 - Pão na chapa \n5 - Refrigerante \n");
            Console.Write("Digite o código do produto: ");
            bool sucesso1 = int.TryParse(Console.ReadLine(), out codigo);

            // Validação do código do produto
            if (!sucesso1 || codigo < 1 || codigo > 5)
            {
                Console.WriteLine("Código inválido, favor redigitar.");
                continue; // Permite que o usuário tente novamente sem encerrar o programa
            }

            // Solicitação da quantidade
            Console.Write("Quantas unidades desse produto você comprou? ");
            bool sucesso2 = int.TryParse(Console.ReadLine(), out npedidos);

            // Validação da quantidade
            if (!sucesso2 || npedidos <= 0)
            {
                Console.WriteLine("Digite um valor válido (número inteiro positivo).");
                continue;
            }

            // Calculo baseado no código do produto
            switch (codigo)
            {
                case 1:
                    valor += 4.00 * npedidos;
                    break;

                case 2:
                    valor += 4.50 * npedidos;
                    break;

                case 3:
                    valor += 5.00 * npedidos;
                    break;

                case 4:
                    valor += 2.50 * npedidos;
                    break;

                case 5:
                    valor += 1.50 * npedidos;
                    break;

                default:
                    continue;
            }

            // Pergunta se o cliente deseja continuar
            Console.Write("Deseja mais alguma coisa? (Digite S para sim e qualquer outra coisa para não): ");
            if (!char.TryParse(Console.ReadLine(), out escolha))
            {
                escolha = 'n';
            }
        }

        // Exibe o total da compra
        total = valor;
        Console.WriteLine($"O total da compra foi de R${total.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.ReadLine();
    }
}
