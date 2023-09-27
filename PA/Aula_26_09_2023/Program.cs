using System;

namespace Aula_26_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração das variáveis //
            
            float media, nota0, nota1, nota2, nota3, soma, percFreq;
            
            // Entrada de dados //

            Console.Write("Informe a 1ª nota: ");
            nota0 = float.Parse(Console.ReadLine());
            
            Console.Write("Informe a 2ª nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 3ª nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 4ª nota: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("Informe o Percentual de Frequência: ");
            percFreq = float.Parse(Console.ReadLine());

            // Processamento dos dados //

            soma = nota0 + nota1 + nota2 + nota3;

            media = soma / 4;

            // Teste condicional //

            if (media < 5 && percFreq <= 40)
            {
                Console.WriteLine("Aluno Reprovado!");
            } 
            else if (media < 7 && percFreq <= 60)
            {
                Console.WriteLine("Aluno em Recuperação!");
            } 
            else if (media >= 7 && percFreq > 60)
            {
                Console.WriteLine("Aluno Aprovado!");
            }
            else
            {
                Console.WriteLine("Será analisado pela secretaria acadêmica!");
            }
        }
    }
}
