using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temps = new double[31];
            int i;
            double temp;
            for (i = 0; i < temps.Length; i++)
            {
                    Console.WriteLine($"Infome a temperatura do dia {i+1}");
                    temps[i] = double.Parse(Console.ReadLine());

            }
            Console.Write("Informe uma Temperatura: ");
            temp = double.Parse(Console.ReadLine());
            Console.Write("Aconteceram nos dias: ");
            for (i = 0; i < temps.Length; i++)
            {
                if (temps[i] == temp)
                {
                    Console.Write($"{i+1}, ");
                }
            }
            Console.ReadLine();
          
            
        }
    }
}
