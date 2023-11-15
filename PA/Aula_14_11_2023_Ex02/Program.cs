using System;

namespace Aula_14_11_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int limite;

            Console.WriteLine("Digite o número desejado: ");
            limite = int.Parse(Console.ReadLine());

            for(int contador = 1; contador <= limite; contador++)
            {
                Console.WriteLine($"{contador % 2 == 1}");
                Console.ForegroundColor = ConsoleColor.Red;
            }

        }
    }
}
