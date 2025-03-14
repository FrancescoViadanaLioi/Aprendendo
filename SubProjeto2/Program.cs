namespace SubProjeto2
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Quanto foi a compra?");
            double com = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Quanto que foi dado ao caixa?");
            double rec = double.Parse(Console.ReadLine()!);

            double res = (rec - com);

            double div = (res * (-1));
            {

            //if e else são condições

                if (res >= 0)
                {
                    Console.WriteLine($"Seu troco é de R${res}.");
                }
                else
                {
                    Console.WriteLine($"Você deve R${div}.");
                }
            }
        }
    }

}