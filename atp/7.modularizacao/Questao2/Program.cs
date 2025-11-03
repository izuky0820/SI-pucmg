using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    internal class Program
    {
        static double Hipotenusa(double a, double b)
        {
            double h = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
            return h;
        }

        static void Main(string[] args)
        {

            double a, b;
            Console.WriteLine("Informe os valores de A e B: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            double c = Hipotenusa(a, b);
            Console.Write($"Hipotenusa: {c}");
            Console.ReadLine();

        }
    }
}
