using System;

namespace Aula_09_11_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "S";
            
            while (resposta.ToUpper() == "S")
            {
                Console.Clear();

                CalcularTabuada();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Deseja continuar? ");
                resposta = Console.ReadLine();
            }
                       
        }
        static void CalcularTabuada()
        {
            int fator, limite;

            Console.WriteLine("Digite o fator desejado: ");
            fator = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o limite da tabuada: ");
            limite = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= limite; contador++)
            {
                if (contador % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
            }
        }
    }
}
