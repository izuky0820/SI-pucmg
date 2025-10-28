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
            double[,] mat = new double[10, 10];
            double[,] mat2 = new double[10, 10];
           
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.WriteLine($"Valor para matriz: ");
                    mat[i, j] = double.Parse(Console.ReadLine());

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
            Console.WriteLine("Nova Matriz");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                mat[i, i] = Math.Sqrt(mat[i, i]);
            }

            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    mat2[i, j] = mat[i, j];
                    Console.Write(mat2[i, j] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
