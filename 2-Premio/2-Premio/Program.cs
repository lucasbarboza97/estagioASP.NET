using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Premio
{
    class Program
    {

        static void Main(string[] args)
        {
            double calcularPremio(double pre, string fat, int quantidade)
            {
                double soma;
                switch (fat)
                {
                    case "basic":
                        soma = pre * 1 * quantidade;
                        return soma;
                }
                    
            }

            Console.WriteLine("Digite o valor do prêmio: ");
            double premio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o fator de multiplicação: ");
            string fator = String.Format(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                double valorTotal = calcularPremio(premio, fator, qtd);
                double resultado = resultado + valorTotal;
                Console.WriteLine(resultado);
            }
        }
    }
}
