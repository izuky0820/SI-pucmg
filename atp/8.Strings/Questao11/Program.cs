using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao11
{
    internal class Program
    {
        static string[,] CriaMatriz(string csv)
        {
            string[] vet1 = csv.Split('\n');
            int linha = vet1.Length;
            int coluna = vet1[0].Split(',').Length;
            string[,] mat = new string[linha, coluna];
            for(int i = 0; i < mat.GetLength(0); i++) 
            {
                string[] vet2 = vet1[i].Split(',');
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    
                    mat[i, j] = vet2[j];
                }
            }
            return mat;
        }
        static void Main(string[] args)
        {
            string csv = "nome,idade,sexo\nAna,25,F\nJoão,30,M\nMaria,22,F";
            string[,] mat = CriaMatriz(csv);
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
