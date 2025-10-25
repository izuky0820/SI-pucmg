using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int[5];
            int[] vet2 = new int[5];
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write("Valor em vet1: ");
                vet1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < vet2.Length; i++)
            {
                Console.Write("Valor em vet2 : ");
                vet2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nSoma: ");
            for (int i = 0; i < vet1.Length; i++)
            {
                int soma = vet1[i] + vet2[i];
                Console.WriteLine($"{vet1[i]} + {vet2[i]} = {soma}");
            }
            Console.WriteLine("\nProduto: ");
            for (int i = 0; i < vet1.Length; i++)
            {
                int produto = vet1[i] * vet2[i];
                Console.WriteLine($"{vet1[i]} x {vet2[i]} = {produto}");
            }
            Console.WriteLine("\nDiferença: ");
            for (int i = 0; i < vet1.Length; i++)
            {
                int diferenca = vet1[i] - vet2[i];
                Console.WriteLine($"{vet1[i]} - {vet2[i]} = {diferenca}");
            }
            Console.WriteLine("\nInterseção: ");
            for (int i = 0; i < vet1.Length; i++)
            {
                for (int j = 0; j < vet2.Length; j++)
                {
                    if (vet1[i] == vet2[j])
                    {
                        Console.WriteLine($"{vet1[i]}");
                       
                    }
                }
            }
            Console.WriteLine("\nUnião: ");
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.WriteLine(vet1[i]);
            }
            for (int j = 0; j < vet2.Length; j++)
            {
                bool existe = false;
                for (int i = 0; i < vet1.Length; i++)
                {
                    if (vet2[j] == vet1[i])
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    Console.WriteLine(vet2[j]);
                }
            }
        }
            
        
    }
}
