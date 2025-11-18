using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao6
{
    internal class Program
    {
        static string TrocaVogal(ref string str)
        {
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
            str = str.ToLower();
            for(int i = 0; i < vogais.Length; i++)
            {
                for(int j = 0; j < str.Length; j++)
                {
                    if (str[j] == vogais[i]) {str = str.Replace(str[j], '*'); }
                }
            }
            return str;
        }

        static void Main(string[] args)
        {
            Console.Write("Palavra: ");
            string p = Console.ReadLine();
            TrocaVogal(ref p);
            Console.Write(p);
            Console.ReadLine();
        }
    }
}
