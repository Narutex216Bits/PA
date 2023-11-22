using System;

namespace Aula_21_11_2023_Ex01B
{
    class Program
    {
        static void Main(string[] args)
        {
            float height, min, max;
            
            Console.WriteLine("Digite a altura desejada: ");
            height = float.Parse(Console.ReadLine());
            min = height;
            max = height;

            for (int i = 1; i <= 15; i++)
            {
                height = float.Parse(Console.ReadLine());

                if (height > max)
                    max = height;
                if (height < min)
                    min = height;
            }
            Console.WriteLine("Altura máxima = {0}", max);
            Console.WriteLine("Altura mínima = {0}", min);
        }
    }
}
