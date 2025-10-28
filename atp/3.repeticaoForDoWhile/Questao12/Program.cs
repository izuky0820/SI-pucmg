using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, impar=1, raiz=0, result;
            Console.Write("Informe o número: ");
            num = int.Parse(Console.ReadLine());
            result = num;
            do
            {
                result -= impar;
                impar += 2;
                raiz++;
            }
            while (result>0);
            if (result == 0)
            {
                Console.WriteLine($"A raiz de {num} é {raiz}");
            }
            else
            {
                Console.WriteLine($"{num} não possui raiz exata");
            }
        }
    }
}
