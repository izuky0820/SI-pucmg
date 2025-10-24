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
            int x, y;
            Console.Write("Informe x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Informe y: ");
            y = int.Parse(Console.ReadLine());
            if ((x > y) || (x % 2 == 0) || (y % 2 == 0)){
                Console.Write("Número inválido");
            }
            else
            {
                while(x <= y)
                {
                    Console.WriteLine(x);
                    x += 2;
                    

                }
            }
            Console.ReadLine();


        }
    }
}
