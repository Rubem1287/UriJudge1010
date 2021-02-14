using System;
using System.Globalization;
namespace UriJudge1010
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;
            double valor1 = 0;

            string[] vetor = Console.ReadLine().Split(' ');
            int peca = int.Parse(vetor[0]);
            int quant = int.Parse(vetor[1]);
            double preco = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            valor = preco * quant;

               string[] vetor1 = Console.ReadLine().Split(' ');
            int peca1 = int.Parse(vetor1[0]);
            int quant1 = int.Parse(vetor1[1]);
            double preco1 = double.Parse(vetor1[2], CultureInfo.InvariantCulture);

            valor1 = preco1 * quant1;

            Console.WriteLine("Valor a pagar : "+(valor+valor1).ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
