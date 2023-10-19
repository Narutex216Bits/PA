using System;

namespace Aula_19_10_2023_While_Ex02
{
    class Program
    {
        static void Main(string[] args)
            // declaração das variáveis //
            
        {
            int contador = 1;
            int multiplicador;

            Console.Write("Digite o multiplicador da tabuada: ");
            multiplicador = int.Parse(Console.ReadLine());

            while(contador <= 10)
            {
                Console.WriteLine($"{multiplicador} x {contador} = {multiplicador * contador}");
                contador++;
            }
            Console.WriteLine("***Fim da Tabuada***");

        }
    }
}
