using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, princ=0, secun=0;
            Console.Write("Tamnaho da matriz quadrada: ");
            n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            Random r = new Random();
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = r.Next(20);
                }
            }
            Console.WriteLine("Matriz");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                    if (i + j == mat.GetLength(0) - 1) { secun += mat[i, j]; }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nSoma das linhas");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                int somaL = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    somaL += mat[i, j];

                }
                Console.WriteLine($"Linha {i+1}: {somaL}");
            }
            Console.WriteLine("\nSoma das Colunas");
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                int somaC = 0;
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    somaC += mat[i, j];
                }
                Console.WriteLine($"Coluna {j+1}: {somaC}");

            }
            Console.Write("\nSoma da diagonal principal: ");
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                princ += mat[i, i];
            }
            Console.WriteLine(princ);
            Console.WriteLine($"Soma da diagonal secundária: {secun}");
        }
    }
}
