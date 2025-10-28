using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Questao3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota, media, max = double.MinValue, min = double.MaxValue, soma=0;
            int i, op;
            double[] notas = new double[200];
            for (i = 0; i < notas.Length; i++)
            {
                Console.Write("Nota: ");
                nota = double.Parse(Console.ReadLine());
                if (nota >= 0.0 && nota <= 100.0)
                {
                    notas[i] = nota;
                    soma += nota;
                }
                else
                {
                    Console.WriteLine("Nota inválida");
                    i--;
                }
            }
            media = soma / 200;
            do
            {
                Console.WriteLine("\nOpções\r\n1. Mostrar menor nota\r\n2. Mostrar maior nota\r\n3. Pesquisar nota\r\n4. Mostrar média das notas e quantidade de notas acima da média\r\n5. Sair");
                op = int.Parse(Console.ReadLine());
                double p;
                switch (op)
                {
                    case 1:
                        foreach (double n in notas)
                        {
                            if (n < min) { min = n; }
                        }
                        Console.Write($"Menor nota: {min}");
                        break;
                    case 2:
                        foreach (double n in notas)
                        {
                            if (n > max) { max = n; }
                        }
                        Console.Write($"Maior nota: {max}");
                        break;

                    case 3:
                        Console.Write("Pesquisa: ");
                        p = double.Parse(Console.ReadLine());
                        Console.Write("Posições: ");
                        for (i = 0; i < notas.Length; i++)
                        {
                            if (notas[i] == p) { Console.Write($"{i}, "); }
                        }
                        break;
                    case 4:
                        Console.Write($"Média: {media} \nAs notas maiores que a média são: ");
                        foreach (double n in notas)
                        {
                            if (n > media) { Console.Write($"{n}, "); }
                        }
                        break;
                    case 5:
                        Console.Write("Fim do programa");
                        break;
                    default:
                        Console.Write("Inválido");
                        break;
                }
            }
            while (op == 1 || op == 2 || op == 3 || op == 4);
           
        }
    }
}
