using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            for (int i = 1; i <=8; i++)
            {
                soma += Math.Pow((-10), i);
            }
            Console.Write(soma);
            Console.ReadLine();
        }
    }
}
