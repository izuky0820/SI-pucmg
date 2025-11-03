using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao7
{
    internal class Program
    {
        static double Somatorio(int n)
        {
            double s = 1;
            for (int i = 2; i <=n; i++)
            {
                s += 1 / (double)i;
            }
            return s;
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Informe n: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n<=0);
            

            double soma = Somatorio(n);
            Console.Write(soma);
        }
    }
}
