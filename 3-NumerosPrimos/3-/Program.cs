using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            int qtdPrimo = 0;
            while (numero >= 1)
            {
                bool ePrimo = contarNumerosPrimos(numero);
                if (ePrimo == true)
                {
                    qtdPrimo++;
                }
                numero--;
            }
            Console.WriteLine(qtdPrimo);


            bool contarNumerosPrimos(int num)
            {
                int divisores = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        divisores++;
                            
                    }
                }
                if (divisores == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            Console.ReadKey();
        }
    }
}
