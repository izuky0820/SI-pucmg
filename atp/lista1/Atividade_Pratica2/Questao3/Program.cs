using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, a;
            char cnh;
            Console.WriteLine("Diga sua idade: ");
            i = int.Parse(Console.ReadLine());
            if (i < 21)
            {
                Console.WriteLine("Requisitos não atendidos");
            }
            else
            {
                Console.WriteLine("Qual o tipo da carteira: ");
                cnh = char.Parse(Console.ReadLine());
                Console.WriteLine("Há quantos anos possui essa carteira: ");
                a = int.Parse(Console.ReadLine());
                if ((cnh == 'b' || cnh == 'B') && (a >= 2) || (cnh == 'c' || cnh == 'C') && (a >= 1))
                {

                    Console.WriteLine("Requisitos atendidos");
                }
                else
                {
                    Console.WriteLine("Requisitos não atendidos");
                }
            }
                         
 
           
            Console.ReadLine();
        }
             

    }
    }
