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
               if (contador%2==1)
                {
                    Console.WriteLine(contador);
                    Console.ForegroundColor = ConsoleColor.Red;
                }        
            }

        }
    }
}
