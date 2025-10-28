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
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            int[,] mat = new int[10,10];
            Random r = new Random();
            for (int i = 0; i < vet1.Length; i++)
            {
                vet1[i] = r.Next(0, 11);
                vet2[i] = r.Next(0, 11);
            }
            Console.WriteLine("Vetor 1");
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write(vet1[i] + " ");
               
            }
            Console.WriteLine("\nVetor 2");
            for (int i = 0; i < vet2.Length; i++)
            {
                Console.Write(vet2[i] + " ");

            }

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = vet1[i] * vet2[j];
                }
            }
            Console.WriteLine("\nMatriz");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
