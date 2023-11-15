using System;

namespace Aula_14_11_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num0, num1;
            
            for(int contador = 1; contador <= 3; contador++)
            {
                Console.WriteLine("Digite o primeiro valor da subtração: ");
                num0 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Segundo valor da subtração: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine($"O resultado da Subtração é: {num0 - num1}");
            }

            Console.WriteLine("Fim das contas!");
        }
    }
}
