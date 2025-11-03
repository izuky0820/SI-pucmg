using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao5
{
    internal class Program
    {
        /*05. Implemente um método que receba um vetor de char como parâmetro e retorne o número de vogais que
constam no vetor.*/

        static int Vogais(char[] vet)
        {
            int cont = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == 'a' || vet[i] == 'e' || vet[i] == 'i' || vet[i] == 'o' || vet[i] == 'u') { cont++; }
                
            }
            return cont;
        }

        static void Main(string[] args)
        {
            char[] vet = new char[5];
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write($"Caractere {i+1}: ");
                vet[i] = char.Parse(Console.ReadLine());
            }
            int contvogais = Vogais(vet);
            Console.Write(contvogais);
            Console.ReadLine();
        }
    }
}
