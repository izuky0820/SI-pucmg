using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Dimensão: ");
            x = int.Parse(Console.ReadLine());
            int[,] mat = new int[x, x];
            Random r = new Random();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = r.Next(0, 51);

                }
            }

            Console.WriteLine("Matriz");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[] vet = new int[x];
            int max;
            double soma = 0;
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                max = int.MinValue;
                for (int i = 0; i < mat.GetLength(0); i++)
                {

                    if (mat[i, j] > max)
                    {
                        max = mat[i, j];
                        vet[j] = max;
                    }

                }
            }
            Console.WriteLine("\nVetor");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
                soma += vet[i];

            }

            Console.WriteLine($"\nMédia: {soma / vet.Length}");
        }
    }
}
