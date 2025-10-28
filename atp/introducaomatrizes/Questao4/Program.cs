using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 6];
            int[,] mat2 = new int[3, 6];
            int soma1 = 0, soma2 = 0;
            Random r = new Random();

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {

                    mat[i, j] = r.Next(1, 51);
                    if (j % 2 ==0) { soma1 += mat[i, j]; }
                    if (j % 2 == 1 && j > 1) { soma2 += mat[i, j]; }


                }
            }
            Console.WriteLine("Primeira Matriz");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[] vsoma = new int[3];
            for (int i = 0; i < mat.GetLength(0); i++)
            {

                vsoma[i] = mat[i, 1] + mat[i, 2];

                
            }
            Console.WriteLine($"Soma das colunas pares: {soma1}");
            Console.WriteLine($"Média das colunas 3 e 5: {(double)soma2 / 6}");

            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    if (j == 5) { mat[i, j] = vsoma[i]; }
                    mat2[i, j] = mat[i, j];
                }
           
            }
            Console.WriteLine("Nova Matriz");
            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    Console.Write(mat2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
