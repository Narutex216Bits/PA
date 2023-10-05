using System;

namespace Aula_05_10_2023_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração das variáveis //

            float salario, aumento, resultado;

            // entrada de dados //

            Console.Write("Insira o valor do salário: ");
            salario = float.Parse(Console.ReadLine());

            // Processamento de dados e tomada de decisão //

            if (salario <= 3000)
            {
                aumento = (salario / 2);
                resultado = salario + aumento;
                Console.WriteLine($"Ao aumento salaial será de:{resultado}");
            }
            else if (salario >= 3001)
            {
                aumento = (salario / 5);
                resultado = salario + aumento;
                Console.WriteLine($"Ao aumento salarial será de:{resultado}");
            }
            else if (salario >= 7000)
            {
                aumento = salario / 100 * 15;
                resultado = salario + aumento;
                Console.WriteLine($"Ao aumento salarial será de:{resultado}");
            }
            else
            {
                Console.WriteLine("Seu salário não receberá aumento");
            }
            
        }
    }
}
