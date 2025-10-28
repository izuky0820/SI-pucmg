using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] gab = {1,4,2,3,3,4,1,1,3,2 };
            int[,] provas = new int[5, 10];
            Random r = new Random();
            for(int i = 0; i < provas.GetLength(0); i++)
            {
                for (int j = 0; j < provas.GetLength(1); j++)
                {
                    provas[i, j] = r.Next(1, 5);

                }
            }

            Console.WriteLine("Gabarito:");
            for (int i = 0; i < gab.Length; i++)
            {
                Console.Write(gab[i] + " ");
            }

            Console.WriteLine("\nNotas: ");
            for (int i = 0; i < provas.GetLength(0); i++)
            {
                for (int j = 0; j < provas.GetLength(1); j++)
                {
                    Console.Write(provas[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[] notas = new int[provas.GetLength(0)];

            for (int i = 0; i < provas.GetLength(0); i++)
            {
                for (int j = 0; j < provas.GetLength(1); j++)
                {
                    if (provas[i, j] == gab[j]) { notas[i] += 1; } 
                }
            }
            Console.WriteLine();

            double soma = 0;
            int max = int.MinValue;
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Nota do aluno {i + 1}: {notas[i]}");
                soma += notas[i];
                if (notas[i] > max) { max = notas[i]; }
                    
                
            }
            Console.WriteLine($"Média: {soma / notas.Length}");
            Console.WriteLine($"Maior nota: {max}");
            Console.ReadLine();
        }
    }
}
