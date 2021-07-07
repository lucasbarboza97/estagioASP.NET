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
                int vogal = 0;
                char[] caracteres = { 'a', 'e', 'i', 'o', 'u' };


                char[] nome_completo = frase.ToLower().ToCharArray();

                for (int conta = 0; conta < nome_completo.Length; conta++)
                {
                    if (caracteres.Contains(nome_completo[conta]))
                    {
                        vogal++;
                    }
                }

                Console.WriteLine("Total de vogais: " + vogal);
                Console.Read();

                Console.ReadKey();
            }

            calcularVogal("Luby Software");
            Console.ReadKey();

        }
    }
}
