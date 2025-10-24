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
            double x=1, y=20, s=0;
            while (x <= 20)
            {
                s += Math.Pow(x, y);
                x++;
                y--;

            }
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
