using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao8
{
    internal class Program
    {
        static double Somatorio(int n)
        {
            double s = 0;
            for(int i = 1; i <=n; i++)
            {
                double num = Math.Pow(i, 2) + 1;
                double den = i + 3;
                s += num / den;
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
            while (n <= 0);


            double soma = Somatorio(n);
            Console.Write(soma);
        }
    }
}
