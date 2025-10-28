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
            int num;
            Console.WriteLine("Informe o número: ");
            num = int.Parse(Console.ReadLine());
            if ((num % 3 == 0) && (num % 5 == 0))
            {
                Console.WriteLine("Divisível por 3 e por 5");
            }
            else if ((num % 3 == 0) && (num % 5 > 0))
            {
                Console.WriteLine("Divisível apenas por 3");
            }
            else if ((num % 3 > 0) && (num % 5 == 0))
            {
                Console.WriteLine("Divisível apenas por 5");
            }

            else
            {
                Console.WriteLine("Não é divisível");
            }
            Console.ReadLine();
        }
    }
}
