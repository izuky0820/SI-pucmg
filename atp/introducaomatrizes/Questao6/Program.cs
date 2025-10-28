using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[4, 4];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"Número para posição [{i + 1},{j + 1}]: ");
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

            bool superior = true;
    

            for (int i = 0; i < mat.GetLength(0); i++)
            {

                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i > j && mat[i,j] != 0) { superior = false; }
                }


            }
            if (superior) { Console.WriteLine("\nÉ uma matriz triangular superior"); }
            else { Console.WriteLine("\nNão é triangular superior"); }




        }
    }
}
