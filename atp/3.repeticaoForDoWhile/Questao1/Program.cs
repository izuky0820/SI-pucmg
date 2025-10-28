using System;
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
            double va, vt, metros, valormetro, pag;

            for (int i = 1; i<=2; i++)
            {
                va = 0; vt = 0; metros = 0; pag = 0;
                Console.Write("Qual o valor do vale alimentação? ");
                va = double.Parse(Console.ReadLine());
                Console.Write("Qual o valor do vale transporte? ");
                vt = double.Parse(Console.ReadLine());
                Console.Write("Metros quadrados produzidos:  ");
                metros = double.Parse(Console.ReadLine());
                if (metros < 10)
                {
                    valormetro = metros * 10.00;
                }
                else if (metros >= 10 && metros <+20)
                {
                    valormetro = metros * 11.50;
                }
                else
                {
                    valormetro = metros * 13.00;
                }
                pag = va + vt * 2 + valormetro;
                Console.WriteLine($"O pagamento para o pedreiro {i} será R${pag}");


                
            }
            Console.ReadLine();
        }
    }
}
