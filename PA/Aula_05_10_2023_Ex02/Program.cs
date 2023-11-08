using System;

namespace Aula_05_10_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escrever um algoritmo que receba um o valor de um salário e com base nos 
            //seguintes critérios abaixo aplique o reajuste salarial:
            //a) 50 % para aqueles que ganham até 3.000,00
            //b) 20 % para aqueles que ganham acima de 3.000,00 até 7.000,00
            //) 15 % para aqueles que ganham acima de 7.000,00 até 10.000,00
            //d) 10 % para os demais funcionários

            float salario, soma;

            Console.Write("Digite o valor do salário: ");
            salario = float.Parse(Console.ReadLine());

            if (salario <= 3.000)
            {
                soma = salario + 50 / 100;
                Console.Write("O salario teve um aumento de 50%" + soma);
            }

            //(media < 5 && percFreq <= 40 )
        }
    }
}
