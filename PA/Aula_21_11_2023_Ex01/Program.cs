using System;

namespace Aula_21_11_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // int contagem;

            float altura;
            float maior = 0, menor = 0;
            
            for(int contador =1; contador <= 15; contador++)
            {
                Console.WriteLine("Digite a altura: ");
                altura = float.Parse(Console.ReadLine());

                if (altura >= maior)
                    maior = altura;

                if (altura <= menor || menor == 0)
                    menor = altura;
            }

            Console.WriteLine($"A Maior altura é:{maior}");
            Console.WriteLine($"A Menor altura é:{menor}");
        }
    }
}
