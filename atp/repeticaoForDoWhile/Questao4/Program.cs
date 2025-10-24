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
            double temp=0, max=double.MinValue, min = double.MaxValue, diamaior=0, diamenor=0;
          
            for (int i = 1; i<=31; i++)
            {
                Console.Write($"Informe a temperatura do dia {i}: ");
                temp = double.Parse(Console.ReadLine());
                if (temp > max)
                {
                    max = temp;
                    diamaior = i;
                }
                if (temp < min)
                {
                    min = temp;
                    diamenor = i;
                }


            }
            
            Console.WriteLine($"A maior temperatura foi de {max} no dia {diamaior}");
            Console.WriteLine($"A menor temperatura foi de {min} no dia {diamenor}");
            Console.ReadLine();

        }
    }
}
