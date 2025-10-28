using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f1 = 0, f2 = 0, f3 = 0, f4 = 0, f5 = 0, cont = 0, i;
            Console.Write("Quantas idades vai informar? ");
            int n = int.Parse(Console.ReadLine());

            
            while (cont < n)
            {
                Console.Write("Informe uma idade: ");
                i = int.Parse(Console.ReadLine());
                if (i >= 1 && i <= 15)
                {
                    f1++;
                }
                else if (i >= 16 && i <= 30)
                {
                    f2++;
                }
                else if (i >= 31 && i <= 45)
                {
                    f3++;
                }
                else if (i >= 46 && i <= 60)
                {
                    f4++;
                }
                else
                {
                    f5++;
                }
                cont++;
            }
            Console.WriteLine(" Quantidade em cada faixa e percentual: ");
            Console.WriteLine($"Faixa 1: {f1} que equivale à {((double)f1 / n) * 100}% \nFaixa 2: {f2} que equivale à {((double)f2 / n) * 100}% \nFaixa 3: {f3} que equivale à {((double)f3 / n) * 100}% \nFaixa 4: {f4} que equivale à {((double)f4 / n)* 100}% \nFaixa 5: {f5} que equivale à {((double)f5 / n) * 100}%");


            Console.ReadLine();
        }
    }
}
