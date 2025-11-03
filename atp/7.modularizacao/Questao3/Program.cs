using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    internal class Program
    {
        static int Mdc(int a, int b)
        {
            while (b != 0)
            {
                int resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }

        
        static int Mmc(int a, int b)
        {
            return (a * b) / Mdc(a, b);
        }

        static void Main(string[] args)
        {
            int op;
            do
            {              

                Console.WriteLine("\nOpções: \r\n1) Calcular MMC\r\n2) Calcular MDC\r\n3) Sair do programa");
                op = int.Parse(Console.ReadLine());
                if(op < 1 || op > 3) { Console.Write("Opção inválida"); }
                else
                {
                    switch (op)
                    {
                        case 1:
                            Console.Write("\nDigite o primeiro número: ");
                            int n1 = int.Parse(Console.ReadLine());

                            Console.Write("Digite o segundo número: ");
                            int n2 = int.Parse(Console.ReadLine());

                            int mmc = Mmc(n1, n2);
                            Console.WriteLine($"O MMC de {n1} e {n2} é {mmc}");
                            break;
                        case 2:
                            Console.Write("\nDigite o primeiro número: ");
                            int a = int.Parse(Console.ReadLine());

                            Console.Write("Digite o segundo número: ");
                            int b = int.Parse(Console.ReadLine());

                            Console.Write("Digite o terceiro número: ");
                            int c = int.Parse(Console.ReadLine());
                            int mdc = Mdc(Mdc(a, b), c);

                            Console.WriteLine($"O MDC de {a}, {b} e {c} é {mdc}");
                            break;
                        default:
                            Console.WriteLine("Fim do programa");
                            break;
                    }
                }
                   
            }
            while (op != 3);
        }
    }
}
