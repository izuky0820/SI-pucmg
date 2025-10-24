using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, soma = 0, dia=0;
            double max = double.MinValue, indice;
            while (cont < 31)
            {
                cont++;
                Console.Write($"Informe o índice pluviométrico do dia {cont}: ");
                indice = double.Parse(Console.ReadLine());
                soma += (int)indice;
                
                if (max < indice)
                {
                    max = indice;
                    dia = cont;
                }
            }
            Console.WriteLine($"Média = {(double)soma / cont}");
            Console.WriteLine($"O valor máximo foi {max} no dia {dia}");
            Console.ReadLine();

            

        }
    }
}
