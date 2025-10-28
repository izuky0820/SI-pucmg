using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] candidatos = { "Perna Longa", "Pluto", "Mickey", "Bob Esponja", "Cebolinha" };
            int[] votos = new int[5];
            int voto, nulo = 0, max = int.MinValue, min = int.MaxValue, codigomaior=0, codigomenor=0;
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("0. Perna Longa\r\n1. Pluto\r\n2. Mickey\r\n3. Bob Esponja\r\n4. Cebolinha \r\nVote: ");
                voto = int.Parse(Console.ReadLine());
                if (voto == 0) { votos[0]++; }
                else if (voto == 1) { votos[1]++; }
                else if (voto == 2) { votos[2]++; }
                else if (voto == 3) { votos[3]++; }
                else if (voto ==4) { votos[4]++; }
                else { nulo++; }                

            }
            for(int i = 0; i < votos.Length; i++)
            {
                if (votos[i] > max) { max = votos[i]; codigomaior = i; }
                if (votos[i] < min) { min = votos[i]; codigomenor = i; }     
            }
            Console.WriteLine($"\nO candidato mais votado foi {candidatos[codigomaior]} (código {codigomaior}) com {max} votos.");
            Console.WriteLine($"O candidato menos votado foi {candidatos[codigomenor]} (código {codigomenor}) com {min} votos.");
            Console.WriteLine($"Votos nulos: {nulo}");


        }
    }
}
