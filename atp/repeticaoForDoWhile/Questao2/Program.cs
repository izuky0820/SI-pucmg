using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n;
            double soma = 1, f = 1;
            do
            {
                Console.WriteLine("Informe n: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0);
            
            for (int i = 1; i<=n; i++)
            {
                f *= i;
                soma += 1 / f;
            }
            Console.Write(soma);
            Console.ReadLine();
        }
    }
}
