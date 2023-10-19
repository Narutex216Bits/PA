using System;

namespace Aula_19_10_2023_While_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int fator, limitador, contador = 1;

            Console.Write("Digite o multiplicador da tabuada: ");
            fator = int.Parse(Console.ReadLine());

            Console.Write("Digite o limitador da tabuada: ");
            limitador = int.Parse(Console.ReadLine());

            while (contador <= limitador)
            {
                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
                contador++;
            }
            Console.WriteLine("***Fim da Tabuada***");

        }
    }
}
