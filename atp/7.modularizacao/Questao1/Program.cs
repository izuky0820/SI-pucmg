using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    internal class Program
    {
        static int Menorvalor(int n1, int n2, int n3, int n4)
        {
            int menor;

            if (n1 < n2 && n1 < n3 && n1 < n4) { menor = n1; }
            else if (n2 < n1 && n2 < n3 && n2 < n4) { menor = n2; }
            else if (n3 < n1 && n3 < n2 && n3 < n4) { menor = n3; }
            else { menor = n4; }
            return menor;
        }

        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Informe 4 números: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            Console.Write($"Menor: {Menorvalor(a,b,c,d)}");
            Console.ReadLine();
        }
        
    }
}
