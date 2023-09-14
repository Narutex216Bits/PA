using System;

namespace Aula_14_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração das variáveis //
            
            decimal n0, n1, n2, n3, media;
            
            // Entrada de dados //

            Console.Write("Digite a primeira nota: ");
            n0 = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            n1 = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            n2 = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            n3 = decimal.Parse(Console.ReadLine());

            // Processamento do programa //

            media = (n0 + n1 + n2 + n3) / 4;

            // Envio da informação final para o usuário //

            Console.WriteLine("A média final é: " + media);

        }
    }
}
