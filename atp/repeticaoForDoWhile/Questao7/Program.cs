using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Questao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long produto = 1;
            for (int i = 4; i <= 15 ; i++)
            {
                produto *= 3 * i - 20;
            }
            Console.Write(produto);
            Console.ReadLine();
        }
    }
}
