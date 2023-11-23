using System;
using System.Threading;

namespace Aula_21_11_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
     
        {
            int totalCandidato0 = 0, totalCandidato1 = 0, totalCandidato2 = 0, totalCandidato3 =0,total = -1, nulo = 0, branco = 0, totalVotos = 0;



            while (total != 0) /* Repete o Loop até digitar 0 */
            {

                urna();
                total = int.Parse(Console.ReadLine());

                switch (total)    /* Utiliza um switch dentro do while para somar os votos para cada variável de cada candidato */
                {
                    case 12:
                        totalCandidato0 += 1;
                        break;
                    case 19:
                        totalCandidato1 += 1;
                        break;
                    case 25:
                        totalCandidato2 += 1;
                        break;
                    case 33:
                        totalCandidato3 += 1;
                        break;
                    case 5:
                        nulo += 1;
                        break;
                    case 6:
                        branco += 1;
                        break;
                    default:                /* Se a pessoa digitar algo diferente do número do candidato ou do zero, retorna para digitar o número certo */
                        if(total != 0)
                        {
                            Console.WriteLine("Voto não computado!");
                            Thread.Sleep(2000);
                            urna();
                            total = int.Parse(Console.ReadLine());
                        }
                        break;
                }

            }

            static void urna()
            {
                Console.Clear();
                Console.WriteLine(" ______________________");
                Console.WriteLine("|----Urna ELetrônica---|");
                Console.WriteLine("|---Justiça Eleitoral--|");
                Console.WriteLine("|______________________|");  /* Aqui é a representação gráfica no console */
                Console.WriteLine("|| Candidato 1 nº 12  ||");
                Console.WriteLine("|| Candidato 2 nº 19  ||");
                Console.WriteLine("|| Candidato 3 nº 25  ||");
                Console.WriteLine("|| Candidato 4 nº 33  ||");
                Console.WriteLine("|| Voto Nulo   nº 5   ||");
                Console.WriteLine("|| Voto Branco nº 6   ||");
                Console.WriteLine("|______________________|");
                Console.WriteLine("|Informe o seu voto:   |");
                Console.WriteLine("|______________________|");

            }

            totalVotos = totalCandidato0 + totalCandidato1 + totalCandidato2 + totalCandidato3;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("....::::Apuração::::....");
            Console.WriteLine($"Candidato 1 tem:{totalCandidato0}votos");
            Console.WriteLine($"Candidato 2 tem:{totalCandidato1}votos");
            Console.WriteLine($"Candidato 3 tem:{totalCandidato2}votos");
            Console.WriteLine($"Candidato 4 tem:{totalCandidato3}votos");
            Console.WriteLine($"Total de votos Nulos:{nulo}");
            Console.WriteLine($"Total de votos brancos:{branco}");
            Console.WriteLine($"% de brancos:{nulo / totalVotos}");
            Console.WriteLine($"% de brancos:{branco / totalVotos}");
        }
    }
}
