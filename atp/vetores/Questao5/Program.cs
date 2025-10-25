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
            double nota, soma=0, media;
            double[] notas = new double[60];
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Nota: ");
                nota = double.Parse(Console.ReadLine());
                if (nota >= 0) 
                { 
                    notas[i] = nota;
                    soma += nota;
                }
                else { i = 60; }
            }
            media = soma / notas.Length;
            Console.Write("Notas: ");
            foreach (double n in notas)
            {
                Console.Write($"{n}, "); 
            }
            Console.Write("\nMaiores que a média: ");
            foreach (double n in notas)
            {
                if (n > media) { Console.Write($"{n}, "); }
            }
        }
    }
}
