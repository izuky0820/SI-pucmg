using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Palavra: ");
            string str = Console.ReadLine();
            for(int i = str.Length-1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.ReadLine();
        }

    }
}
