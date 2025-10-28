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
            Console.WriteLine("Linha e coluna: ");
            int l = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int [,] mat = new int[l,c];
            int [] soma = new int[l];
            int[] somaLinha = new int[l];
            int[,] prefixLinha = new int[l, c];

            Random r = new Random();

            for (int i = 0; i < l; i++)
            {
                int s = 0;
                for (int j = 0; j < c; j++)
                {
                    mat[i, j] = r.Next(0, 11); 
                    s += mat[i, j];
                    prefixLinha[i, j] = s;
                }
                somaLinha[i] = s;
            }


            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Soma: ");
            for (int i = 0; i < soma.Length; i++)
            {
                Console.Write(soma[i] + " ");
            }

           
            
            Console.ReadLine();

        }
    }
}
