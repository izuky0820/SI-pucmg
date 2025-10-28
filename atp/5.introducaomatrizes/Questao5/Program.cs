using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Questao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[500, 500];
            int[] somaL = new int[500];
            int[] somaC = new int[500];
            int somaP = 0, somaS = 0;
            bool x = true;
            Random r = new Random();

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                int soma = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = r.Next(1, 101);
                    soma += mat[i, j];


                }
                somaL[i] = soma;
            }

            for (int j = 0; j < mat.GetLength(1); j++)
            {
                int soma = 0;
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    soma += mat[i, j];
                }
                somaC[j] = soma;

            }


            for (int i = 0; i < mat.GetLength(0); i++)
            {
                somaP += mat[i, i];
            }

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                    if (i + j == mat.GetLength(0) - 1) { somaS += mat[i, j]; }
                }
                Console.WriteLine();
            }
            int valorBase = somaL[0];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                if (somaL[i] != valorBase || somaC[i] != valorBase) { x = false; }

            }

           if (somaP != valorBase || somaS != valorBase) { x = false; }

           if (x) { Console.WriteLine("Quadrado mágico"); }
           else { Console.WriteLine("Não é um quadrado mágico"); }



        }

            

    }
}
