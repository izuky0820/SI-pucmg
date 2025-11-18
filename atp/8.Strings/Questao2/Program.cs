using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
   /* Escreva um programa que leia duas strings.Se as strings forem iguais, escreva “strings iguais”. Caso contrário,
imprima a string que possui o maior tamanho e, em seguida, a string resultante da concatenação das duas strings */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Palavra 1: ");
            string str1 = Console.ReadLine();
            str1 = str1.ToLower();
            Console.Write("Palavra 2: ");
            string str2 = Console.ReadLine();
            str2 = str2.ToLower();
            if (str1 == str2) { Console.WriteLine("strings iguais"); }
            else
            {
                if(str1.Length > str2.Length) { Console.Write(str1); }
                else 
                { 
                    Console.WriteLine(str2);
                    Console.Write(str1 + " " + str2);
                }
                
            }
            Console.ReadLine();
        }
    }
}
