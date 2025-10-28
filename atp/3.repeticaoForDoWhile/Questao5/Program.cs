using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  soma = 0;
            for(int i = 4; i <= 10; i++ )
            {
                soma += 4 * i - 5;
            }
            Console.Write(soma);
            Console.ReadLine();
        }
    }
}
