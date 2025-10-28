using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n, contL = 0, contC = 0;
            Console.WriteLine("Infome o tamanho da matriz:");
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int[,] mat = new int[m, n];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {

                    Console.Write($"Valor para matriz na posição [{i + 1},{j + 1}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());

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
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                int somaL = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    somaL += mat[i, j];

                }
                if (somaL == 0) { contL++; }
            }

            for (int j = 0; j < mat.GetLength(1); j++)
            {
                int somaC = 0;
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    somaC += mat[i, j];
                }
                if (somaC == 0) { contC++; }

            }
            Console.WriteLine($"Linhas nulas: {contL}");
            Console.WriteLine($"Colunas nulas: {contC}");
        }

    }
}

