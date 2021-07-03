using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int calcularFatorial(int x)
            {
                int i,  fatorial;
                fatorial = x;
                for (i = x - 1; i >= 1; i--)
                {
                    fatorial = fatorial * i;
                }
                return fatorial;

            }
            int valor = 5;
            int resultado = calcularFatorial(valor);
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
