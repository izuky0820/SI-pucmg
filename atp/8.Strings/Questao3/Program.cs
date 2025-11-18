using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    internal class Program
        /*Escreva um método que receba como parâmetro uma string e retorne o número de vogais e de consoantes dessa
string. Considere que a string lida terá apenas letras(Dica: consoantes não são vogais)*/
    {
        static int VogaisConsoantes(string str, ref int v, ref int c)
        {
            string sla = "aeiou";
            str = str.ToLower();
            foreach (char i in str)
            {
                if (sla.IndexOf(i) == -1) { c++; }
                else { v++; }
            }
            return v;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Palavara: ");
            string palavra = Console.ReadLine();
            palavra = palavra.ToLower();
            int vogal = 0, cons = 0;
            VogaisConsoantes(palavra, ref vogal, ref cons);
            Console.Write($"Vogais:{vogal} \nConsoantes: {cons}");
            Console.ReadLine();
        }
    }
}
