using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano;
            Console.Write("Informe um ano: ");
            ano = int.Parse(Console.ReadLine());
            string bissexto = (ano % 400 == 0) || ((ano % 4 == 0) && (ano % 100 != 0)) ?"É bissexto" : "Não é bissexto";
            Console.WriteLine(bissexto);
            Console.ReadLine();
        }
    }
}
