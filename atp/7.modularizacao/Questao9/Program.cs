using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao9
{
    internal class Program
    {
        static void ObterMaiorMenor(float[] vet, out float menor, out float maior)
        {
            maior = float.MinValue; 
            menor = float.MaxValue;
            foreach(float i in vet)
            {
                if(i > maior) { maior = i; }
                if(i < menor) { menor = i; }

            }
            Console.Write($"Maior: {maior} \nMenor: {menor}");
        }

        static void ImprimirVetor(float[] vet)
        {
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            float[] vet = new float[10];
            float menor, maior;
            Random r = new Random();

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = (float)(r.NextDouble() * 20 + 1);
            }

            ImprimirVetor(vet);
            Console.WriteLine();
            ObterMaiorMenor(vet, out menor, out maior);
        }
    }
}
