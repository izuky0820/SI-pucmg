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
            int num;
            Console.WriteLine("Digite o número: ");
            num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(" Zero");
            }
            else if (num == 1)
            {
                Console.WriteLine("Um");
            }
            else if (num == 2)
            {
                Console.WriteLine("Dois");
            }
            else if (num == 3)
            {
                Console.WriteLine("Três");
            }
            else if (num == 4)
            {
                Console.WriteLine("Quatro");
            }
            else if (num == 5)
            {
                Console.WriteLine("Cinco");
            }
            else
            {
                Console.WriteLine("Número inválido");
            }
            Console.ReadLine();
            



        }
    }
}
