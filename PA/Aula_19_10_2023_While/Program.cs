using System;

namespace Aula_19_10_2023_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            while(contador <= 10)
            {
                Console.WriteLine($"2 x {contador} = {2 * contador}");
                // contador = contador + 1;  // forma mais antiga de incrementar //
                contador++;
            }
            Console.WriteLine("*** Fim da Tabuada ***");
        }
    }
}
