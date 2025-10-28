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
            double precokwh, kwh, media=0, s = 0, max = double.MinValue, min = double.MaxValue, total=0;
            int n = 5;
            for ( int i = 1; i<=n; i++)
            {
                
                Console.Write("\nInforme o preço do kWh: ");
                precokwh = double.Parse(Console.ReadLine());
                Console.Write("Informe a quantidade de kWh consumidos: ");
                kwh = double.Parse(Console.ReadLine());
                total = precokwh * kwh;
                Console.WriteLine($"Total a pagar: R${total:F2}");
                if (total > max)
                {
                    max = total;
                    
                }
                if (total < min)
                {
                    min = total;
                    
                }
                s = s + total;
            }
           
            media = s / n;
            Console.WriteLine($"\nMaior consumo: {max:F2}");
            Console.WriteLine($"Menor consumo: {min:F2}");
            Console.WriteLine($"Média: {media:F2}");

        }
    }
}
