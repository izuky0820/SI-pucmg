using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Questao10
{
    /*Faça um programa que leia dois vetores de inteiros de tamanho 10 representando o número de matrícula
de alunos matriculados em Algoritmos e Técnicas de Programação e DIW.O programa deverá imprimir o
número de matrícula dos alunos que estão matriculados simultaneamente nestas duas disciplinas (ou seja,
calcular a interseção dos dois vetores). Se não existirem alunos matriculados simultaneamente nas duas
disciplinas informar com uma mensagem na tela.A leitura dos valores dos vetores deve ser feita através de
um método.A interseção também deverá ser feita através de um método que irá receber os vetores das
matrículas das duas disciplinas, e deverá retornar um vetor com a interseção desses vetores.*/
    internal class Program
    {
        static int[] LerVetor(int tamanho)
        {
            int[] vetor = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Informe a matrícula {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            return vetor;
        }

        static int[] Intersecao(int[] vet1, int[] vet2)
        {
            int cont = 0;
            int[] novoVet = new int[vet1.Length];
            for(int i = 0; i < vet1.Length; i++)
            {
                for (int j = 0; j < vet2.Length; j++)
                {
                    if (vet1[i] == vet2[j])
                    {
                        bool existe = false;
                        for (int k = 0; k < cont; k++)
                        {
                            if (novoVet[k] == vet1[i]) { existe = true; }

                        }
                        if (!existe)
                        {
                            novoVet[cont] = vet1[i];
                            cont++;
                        }
                    }
                }
            }
            int[] result = new int[cont];
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = novoVet[i];
               
            }
            return result;
            
        }

        static void ImprimirVetor(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmos e Técnicas de Programação ");
            int[] atp = LerVetor(10);
            Console.Write("Matrículas de ATP: ");
            ImprimirVetor(atp);
            Console.WriteLine();
            Console.WriteLine("\nDesenvolvimento de Interfaces Web");
            int[] diw = LerVetor(10);
            Console.Write("Matrículas de DIW: ");
            ImprimirVetor(diw);

            int[] inter = Intersecao(atp, diw);
            Console.WriteLine();
            if(inter.Length == 0) { Console.WriteLine("\nNão há interseção"); }
            else
            {
                Console.WriteLine("\nInterseção: ");
                ImprimirVetor(inter);
            }
        }
    }
}
