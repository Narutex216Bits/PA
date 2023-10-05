using System;

namespace Aula_05_10_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração das variáveis //

            float num0;

            // Entrada de dados //

            Console.Write("Insira o número desejado: ");
                num0 = float.Parse(Console.ReadLine());

            // Processamento e tomada de decisões //

            if (num0 > 10)
            {
                Console.WriteLine("O numero digitado é maior que 10!!!");
            }
            else
            {
                Console.WriteLine("O numero digitado é menor que 10!!!");
            }

        }
    }
}
