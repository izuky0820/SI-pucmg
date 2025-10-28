using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1, cont = 1;
            Console.Write("Informe n: ");
            n = int.Parse(Console.ReadLine());
            while (cont <= n)
            {
                Console.WriteLine(a);
               int c = a + b;
                a = b;
                b = c;
                cont++;
            }



        }
    }
}
