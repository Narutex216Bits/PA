using System;

namespace Aula_26_10_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorFinanciado, valorParcela;
            int qtdeParcela;
            int contador = 1;

            Console.Write("Informe o valor Financiado: ");
            valorFinanciado = float.Parse(Console.ReadLine());

            Console.Write("Informe a Qtde de Parcelas: ");
            qtdeParcela = int.Parse(Console.ReadLine());

            valorParcela = valorFinanciado / qtdeParcela;

            DateTime data = DateTime.Now.Date;

            Console.WriteLine("Usando o While");
            while (contador <= qtdeParcela)
            {
                //Console.WriteLine($"O valor da parcela {contador} é de {valorParcela}");
                Console.WriteLine($"{contador}ª parcela ({data}): {valorParcela:0.00}");
                //Console.WriteLine($"{contador}ª parcela: {valorFinanciado / qtdeParcela:0.00}");
                contador++;
                data = data.AddMonths(1);
            }

            Console.WriteLine("");
            Console.WriteLine("Usando o Do While");
            contador = 1;
            do
            {
                //Console.WriteLine($"O valor da parcela {contador} é de {valorParcela}");
                Console.WriteLine($"{contador}ª parcela: {valorParcela:0.00}");
                Console.WriteLine($"{contador}ª parcela: {valorFinanciado / qtdeParcela:0.00}");
                contador++;
            }
            while (contador <= qtdeParcela);
        }
    }
}
