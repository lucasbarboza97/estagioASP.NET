using System;

namespace _6___Diferença_de_data
{
    class Program
    {
        static void Main(string[] args)
        {
            void calcularDiferencaData(string data1, string data2)
            {
                string data1Formatado = data1.Remove(2,6);
                string data2Formatado = data2.Remove(2, 6);

                int data1Int = Convert.ToInt32(data1Formatado);
                int data2Int = Convert.ToInt32(data2Formatado);


                int diferenca = data2Int - data1Int;

                Console.WriteLine("Diferença " + diferenca);
                Console.Read();
            }

            string dt1 = "10122020";
            string dt2 = "25122020";
            calcularDiferencaData(dt1,dt2);
        }
    }
}
