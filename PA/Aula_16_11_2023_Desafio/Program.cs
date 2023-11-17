using System;

namespace Aula_16_11_2023_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 1;
            int totalIdade = 0;
            int qtdeIdadeDigitada = 0;

            while (idade != 0)
            {
                Console.Write("Digite a idade da pessoa: ");
                idade = int.Parse(Console.ReadLine());

                if (idade == 0)
                    break;
                
                //totalIdade = totalIdade + Idade;
                totalIdade += idade;

                qtdeIdadeDigitada++;
                
            }

            Console.WriteLine($"Média das Idades: {totalIdade / qtdeIdadeDigitada}");
        }
    }
}
