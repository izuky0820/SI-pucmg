using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    internal class Program
    {
        static int QuantCaractere(string str, char c)
        {
            int cont = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c) { cont++; }

            }
            return cont;
        }
        static void Main(string[] args)
        {
            Console.Write("Palavra: ");
            string str = Console.ReadLine();
            Console.Write("Informe um caractere: ");
            char c = char.Parse(Console.ReadLine());
            int quant = QuantCaractere(str, c);
            Console.Write($"O caractere {c} apareceu {quant} vezes");
            Console.ReadLine();


        }
    }
}
