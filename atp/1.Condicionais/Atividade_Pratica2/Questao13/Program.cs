using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char vogal;
            Console.Write("Informe uma letra: ");
            vogal = char.Parse(Console.ReadLine());
            switch (vogal)
            {
                case 'a':
                    Console.Write("Vogal");
                    break;
                case 'e':
                    Console.Write("Vogal");
                    break;
                case 'i':
                    Console.Write("Vogal");
                    break;
                case 'o':
                    Console.Write("Vogal");
                    break;
                case 'u':
                    Console.Write("Vogal");
                    break;
                default:
                    Console.Write("Consoante");
                    break;
            }
            Console.ReadLine();
        }
    }
}
