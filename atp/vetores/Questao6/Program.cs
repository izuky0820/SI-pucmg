using System;
using System.CodeDom.Compiler;
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
            double[] vetA = new double[10];
            double[] vetB = new double[10];
            char[] vetC = new char[10];
            double[] vetD = new double[10];
            for (int i = 0; i < vetA.Length; i++)
            {
                Console.Write("A: ");
                vetA[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < vetB.Length; i++)
            {
                Console.Write("B: ");
                vetB[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < vetC.Length; i++)
            {
                Console.Write("Operador: ");
                vetC[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetA.Length; i++)
            {
                switch (vetC[i])
                {
                    case '+':
                        vetD[i] = vetA[i] + vetB[i];
                        break;
                    case '-':
                        vetD[i] = vetA[i] - vetB[i];
                        break;
                    case '*':
                        vetD[i] = vetA[i] * vetB[i];
                        break;
                    case '/':
                        if (vetB[i] != 0)
                            vetD[i] = vetA[i] / vetB[i];
                        else
                            Console.WriteLine($"Divisão por zero na posição {i}!");
                        break;
                    default:
                        Console.WriteLine($"Operador inválido na posição {i}!");
                        break;
                }
            }
            Console.WriteLine("\nResultados:");
            for (int i = 0; i < vetD.Length; i++)
            {
                Console.Write($"{vetD[i]}, ");
            }


        }
    }
}
