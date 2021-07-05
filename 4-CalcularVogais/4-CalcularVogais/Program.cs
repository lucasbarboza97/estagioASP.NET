using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CalcularVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            void calcularVogal(string frase)
            {
                char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
                int contador = 0;
                for (int i = 0; i < frase.Length; i++)
                {
                    for (int j = 0; j < vogais.Length; i++)
                    {
                        if (Char.IsLetter(frase[i]) && frase[i] == vogais[j]) 
                        {

                            contador++;
                        }
                    }
                }
                Console.WriteLine(contador);
            }

            calcularVogal("Luby Software");
            Console.ReadKey();

        }
    }
}
