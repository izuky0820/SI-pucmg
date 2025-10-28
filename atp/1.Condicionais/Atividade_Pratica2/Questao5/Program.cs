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
            int w, x, y, z;
            double result;
            Console.WriteLine("Escolha uma opção: ");
            w = int.Parse(Console.ReadLine());
            if ((w > 4) || (w < 0))
            {
                Console.WriteLine("Opção inválida");
            }
            else
            {
                Console.WriteLine("Informe x: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe y: ");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe z: ");
                z = int.Parse(Console.ReadLine());
                if (w == 1)
                {
                    Console.WriteLine("Média Geométrica");
                    result = Math.Sqrt(x * y * z);
                    Console.WriteLine("" + result);
                }
                else if (w == 2)
                {
                    Console.WriteLine("Média Ponderada");
                    result = (x + 2*y + 3*z) / 6;
                    Console.WriteLine("" + result);
                }
                else if (w == 3)
                {
                    Console.WriteLine("Média Armônica");
                    result = 1 / 1 / x + 1 / y + 1 / z;
                    Console.WriteLine("" + result);
                }
                else if (w == 4)
                {
                    Console.WriteLine("Média Aritmética");
                    result = (x + y + z) / 3;
                    Console.WriteLine("" + result);
                }
                
            }
       
            Console.ReadLine();
        }
    }
}
 