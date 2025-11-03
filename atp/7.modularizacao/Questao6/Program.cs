using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao6
{
    internal class Program
    {
        static void MultiplicarEscalar(int[,] mat, int n)
        {
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] *= n;
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
            int[,] A = new int[3, 3];
            Random r = new Random();

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i,j] = r.Next(0, 21);
                }
            }

            ImprimirMatriz(A);
            Console.WriteLine();
            Console.Write("Informe n: ");
            int n = int.Parse(Console.ReadLine());
            MultiplicarEscalar(A, n);
            Console.WriteLine();
            ImprimirMatriz(A);

           
        }
    }
}
