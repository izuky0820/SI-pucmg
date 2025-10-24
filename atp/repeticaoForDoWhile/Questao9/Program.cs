using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int voto=0, votob=0, voton=0, v1=0, v2=0, v3=0, max=int.MinValue, maisvot=0;
            char op;
            do
            {
                Console.WriteLine("\nVotação: ");
                Console.WriteLine("1 - Candidato 1 \n2 - Candidato 2 \n3 - Candidato 3 \n4 - Voto branco \nAperte qualquer outra tecla para voto nulo. ");
                Console.Write("Voto: ");
                voto = int.Parse(Console.ReadLine());
                switch (voto)
                {
                    case 1:
                        v1++;
                        break;
                    case 2:
                        v2++;
                        break;
                    case 3:
                        v3++;
                        break;
                    case 4:
                        votob++;
                        break;
                    default:
                        voton++;
                        break;
                    
                }
                Console.Write("\nDeseja adicionar mais um voto? (s/n) ");
                op = char.Parse(Console.ReadLine());
            }
            while (op == 's' || op == 'S');
            if (v1 > max)
            {
                max = v1;
                maisvot = 1;
            }
            if (v2 > max)
            {
                max = v2;
                maisvot = 2;
            }
            if (v3 > max)
            {
                max = v3;
                maisvot = 3;
            }

            Console.WriteLine($"\nCandidato mais votado foi {maisvot} com {max} votos");
            Console.WriteLine($"Votos do candidato 1: {v1} ");
            Console.WriteLine($"Votos do candidato 2: {v2} ");
            Console.WriteLine($"Votos do candidato 3: {v3} ");
            Console.WriteLine($"Votos brancos: {votob} ");
            Console.WriteLine($"Votos nulos: {voton} ");
            Console.ReadLine();
     
        


        }
    }
}
