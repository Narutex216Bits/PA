using System;

namespace Aula_21_11_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int candidato0, candidato1, candidato2, candidato3, total, nulo, branco;


           while ()
            Console.WriteLine("----Urna ELetrônica---");
            Console.WriteLine("---Justiça Eleitoral--");
            Console.WriteLine("----------------------");
            Console.WriteLine("| Candidato 1 nº 12  |");
            Console.WriteLine("| Candidato 1 nº 19  |");
            Console.WriteLine("| Candidato 1 nº 25  |");
            Console.WriteLine("| Candidato 1 nº 33  |");
            Console.WriteLine("| Voto Nulo          |");
            Console.WriteLine("| Voto Branco        |");
            Console.WriteLine("----------------------");
            Console.WriteLine("Informe o seu voto: ");
            total = int.Parse(Console.ReadLine());

            if (total == 12)
                candidato0 = total;

            if (total == 19)
                candidato1 = total;

            if (total == 25)
                candidato2 = total;

            if (total == 33)
                candidato3 = total;

            if (total == nulo)
                nulo = total;

            if (total == branco)
                branco = total;



            Console.WriteLine($"Candidato1 tem:{candidato0}votos");
            Console.WriteLine($"Candidato1 tem:{candidato1}votos");
            Console.WriteLine($"Candidato1 tem:{candidato2}votos");
            Console.WriteLine($"Candidato1 tem:{candidato3}votos");
        }
    }
}
