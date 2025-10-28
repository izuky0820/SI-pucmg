using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long produto = 1;
            for(int i = 1; i <=7; i++)
            {

                produto *= (long)Math.Pow(i,3) - 9;
            }
            Console.Write(produto);
            Console.ReadLine();
        }
    }
}
