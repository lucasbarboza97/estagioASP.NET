using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Calcular_desconto
{
    class Program
    {
        static void Main(string[] args)
        {
            void calcularValorComDescontoFormatado(string val, string desc )
            {
                //string valSemCaracteresNaoNumericos = new string(val.Where(char.IsDigit).ToArray());
                //string descSemCaracteresNaoNumericos = new string(desc.Where(char.IsDigit).ToArray());
                string valSemCaracteresNaoNumericos = val.Remove(0, 3);
                string descSemCaracteresNaoNumericos = desc.Remove(2, 1);

                double valFormatadoDouble = Convert.ToDouble(valSemCaracteresNaoNumericos);
                double descFormatadoDouble = Convert.ToDouble(descSemCaracteresNaoNumericos);

                double descontoAplicado = valFormatadoDouble - valFormatadoDouble * (descFormatadoDouble / 100);

                string descontoAplicatoString = ("R$ " + descontoAplicado.ToString());

                Console.WriteLine("Valor com desconto: " + descontoAplicatoString);
                Console.Read();
            }
            string valor = "R$ 6.800,00";
            string desconto = "30%";
            calcularValorComDescontoFormatado(valor,desconto);
        }
    }
}
