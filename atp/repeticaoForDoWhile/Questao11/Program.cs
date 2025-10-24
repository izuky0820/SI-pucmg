using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bruto, desconto=0;
            char op;

            double d1 = 1412.00 * 0.075;                
            double d2 = (2666.68 - 1412.00) * 0.09;     
            double d3 = (4000.03 - 2666.69) * 0.12;       

            do
            {
                Console.Write("Informe o salário bruto: ");
                bruto = double.Parse(Console.ReadLine());
       
                if (bruto <= 1412.00)
                {
                    desconto = bruto * 0.075;
                }
                else if(bruto >= 1412.01 && bruto <= 2666.68)
                {
                    desconto = d1 + (bruto - 1412.00) * 0.09;
                }
                else if (bruto >= 2666.69 && bruto <= 4000.03)
                {
                    desconto = d1 + d2 + (bruto - 2666.69) * 0.12;
                }
                else
                {
                    if (bruto >= 4000.04 && bruto <= 7786.02)
                    {
                        desconto = d1 + d2 + d3 + (bruto - 4000.04) * 0.14;
                    }
                    else
                    {
                        desconto = d1 + d2 + d3 + (7786.02 - 4000.04) * 0.14;
                    }
                }
                Console.WriteLine($"Seu desconto será: {Math.Round(desconto,2)}");

                Console.WriteLine("Deseja continuar? (s/n) ");
                op = char.Parse(Console.ReadLine());
            }
            while (op == 's' || op == 'S');
            Console.ReadLine();
        }
    }
}
