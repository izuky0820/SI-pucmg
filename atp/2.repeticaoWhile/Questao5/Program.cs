using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 1;
            while (x != 0 && y != 0)
            {
                Console.WriteLine("Informe o valor de de x e y: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                if(x > 0 && y > 0) 
                {
                    Console.WriteLine("Primeiro quadrante");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo quadrante");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro quadrante");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto quadrante");
                }
            }
            Console.ReadLine();
        }
    }
}
