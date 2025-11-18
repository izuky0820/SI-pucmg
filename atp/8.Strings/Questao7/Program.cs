using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao7
{
    internal class Program
    {
        static int QuantPalavras(string frase)
        {
            string[] palavras;
            palavras = frase.Split(' ');
            int quant = palavras.Length;
            return quant;
        }


        static void Main(string[] args)
        {
            Console.Write("Frase: ");
            string frase = Console.ReadLine();
            Console.Write($"A quantidade de palavras é: {QuantPalavras(frase)} ");
            Console.ReadLine();
        }
    }
}
