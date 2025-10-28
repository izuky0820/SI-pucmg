using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 480, num2 = 475, s = 0, cont = 0;
            while (cont < 15)
            {
                s += num1 - num2;
                num1 -= 10;
                num2 -= 10;
                cont++;

            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
