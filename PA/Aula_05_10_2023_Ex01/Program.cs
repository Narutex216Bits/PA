using System;

namespace Aula_05_10_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que receba um número e mostre uma mensagem caso este 
            //número seja maior que 10.

            float num;

            Console.Write("Digite um número: ");
            num = float.Parse(Console.ReadLine());

            if (num <= 10)
            {
                Console.Write("O número digitado foi: " + num);
            }
            else
            {
                Console.Write("o número que foi digitado é maior que 10, tente novamente.");
            }
        }
    }
}
