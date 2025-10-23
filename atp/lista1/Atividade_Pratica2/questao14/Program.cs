using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h, pi;
            char genero;
            Console.Write("Informe seu gênero (F/M): ");
            genero = char.Parse(Console.ReadLine());
            Console.Write("Informe sua altura: ");
            h = double.Parse(Console.ReadLine());
            pi = (genero == 'F' || genero == 'f') ? (62.1 * h) - 44.7 : (72.7 * h) - 58;
            Console.Write("Seu peso ideal é: " + pi + "KG");
            Console.ReadLine();


        }
    }
}
