using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.Write("Diga um número: ");
            dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.Write("Domingo");
                    break;
                case 2:
                    Console.Write("Segunda");
                    break;
                case 3:
                    Console.Write("Terça");
                    break;
                case 4:
                    Console.Write("Quarta");
                    break;
                case 5:
                    Console.Write("Quinta");
                    break;
                case 6:
                    Console.Write("Sexta");
                    break;
                case 7:
                    Console.Write("Sábado");
                    break;
                default:
                    Console.Write("Número inválido");
                    break;
            }
            Console.ReadLine();
        }
    }
}
