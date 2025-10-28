using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Diga um número: ");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.Write("Zero");
                    break;
                case 1:
                    Console.Write("Um");
                    break;
                case 2:
                    Console.Write("Dois");
                    break;
                case 3:
                    Console.Write("Três");
                    break;
                case 4:
                    Console.Write("Quatro");
                    break;
                default:
                    Console.Write("Número inválido");
                    break;
            }
            Console.ReadLine();
        }
    }
}
