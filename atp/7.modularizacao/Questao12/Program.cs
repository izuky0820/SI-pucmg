using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao12
{
    internal class Program
    {
        static void Maior(int[,] A, out int k, out int lin, out int col)
        {
            int max = int.MinValue;
            k = A[0, 0];
            lin = 0;
            col = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for ( int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i,j] > max)
                    {
                        max = A[i,j];
                        k = max;
                        lin = i;
                        col = j;
                        
                    }
                }
            }
        }
        static void ImprimirMatriz(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n, k, lin, col;
            Console.Write("Tamanho: ");
            n = int.Parse(Console.ReadLine());
            int[,] matA = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < matA.GetLength(0); i++)
            {
                for (int j = 0; j < matA.GetLength(1); j++)
                {
                    matA[i, j] = r.Next(0, 51);
                }
            }

            ImprimirMatriz(matA);
            Console.WriteLine();
            Maior(matA, out k, out lin, out col);
            Console.Write($"Maior valor: {k} \nLinha: {lin} \nColuna: {col}");
        }
    }
}
