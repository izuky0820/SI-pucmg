using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            bool iguais = true;
            Console.WriteLine("Informe o tamanho das matrizes: ");
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int[,] mat1 = new int[m, n];
            int[,] mat2 = new int[m, n];
            //Random r = new Random();
            for(int i =0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    /* mat1[i, j] = r.Next(1, 101);
                     mat2[i, j] = r.Next(1, 101);*/
                    Console.WriteLine($"Valor para matriz 1: ");
                    mat1[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine();
            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    /* mat1[i, j] = r.Next(1, 101);
                     mat2[i, j] = r.Next(1, 101);*/
                    Console.WriteLine($"Valor para matriz 2: ");
                    mat2[i,j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine();
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                        
                    if (mat1[i,j] != mat2[i, j]) { iguais=false; }

                }
            }
            if (iguais) { Console.Write("São iguais"); }
            else { Console.Write("Não São iguais"); }
            Console.ReadLine();



        }
    }
}
