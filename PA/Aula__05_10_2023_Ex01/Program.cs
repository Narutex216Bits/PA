using System;

namespace Aula__05_10_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração das variáveis //

            float num0, num1, resultado;
            string operador;

            //Entrada de dados //

            Console.Write("Insira o primeiro valor da calculadora: ");
                num0 = float.Parse(Console.ReadLine());

            Console.Write("Insira o segundo valor da calculadora: ");
                num1 = float.Parse(Console.ReadLine());

            Console.Write("Insira o Operador que você deseja Utilziar: ");
                operador = Console.ReadLine();

            // Processamento dos dados e tomada de decisão //

            if (operador == "+")
            {
                resultado = num0 + num1;
                Console.WriteLine($"Resultado da Soma é {resultado}");
            }
            else if (operador == "-")
            {
                resultado = num0 - num1;
                Console.WriteLine($"Resultado da Subtração é {resultado}");
            }
            else if (operador == "*")
            {
                resultado = num0 * num1;
                Console.WriteLine($"Resultado da Multiplicação é {resultado}");
            }
            else if (operador == "/")
            {
                resultado = num0 / num1;
                Console.WriteLine($"Resultado da Divisão é {resultado}");
            }
            else
            {
                Console.WriteLine("Operador Invalido!");
            }
        }
    }
}
