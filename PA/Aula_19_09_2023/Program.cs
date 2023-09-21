using System;

namespace Aula_19_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração das Variáveis //

            float media, nota0, nota1, nota2, nota3;

            // Entrada de dados //

            Console.Write("Informe a 1ª Nota: ");
            nota0 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 2ª Nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 3ª Nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 4ª Nota: ");
            nota3 = float.Parse(Console.ReadLine());

            // Processamento dos dados //

            media = (nota0 + nota1 + nota2 + nota3) / 4;
                  
            // Informação da média e se o aluno foi aprovado //

            if (media < 5)
            {
                Console.WriteLine("Reprovado!!!");
                Console.WriteLine("Temos mais um Repetente!!!");
            }
            else if (media < 7)
            {
                Console.WriteLine("Recuperação!!!");
                Console.WriteLine("Mais um aluno que vem na escola até o Natal!!!");
            }
            else
            {
                Console.WriteLine("Aprovado!!!");
                Console.WriteLine("Parabóins!!! Você não tem vida social!!!");
            }


        }
    }
}
