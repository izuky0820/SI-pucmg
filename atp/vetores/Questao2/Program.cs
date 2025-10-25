using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  d;
            bool palindromo = true;
            Console.Write("Informe a quantidade de dígitos: ");
            d = int.Parse(Console.ReadLine());
            int[] digitos = new int[d];
            for (int i = 0; i<digitos.Length; i++)
            {
                Console.WriteLine($"Informe o dígito {i+1} ");
                digitos[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0, j = digitos.Length-1; i < j; i++, j--)
            {
                if (digitos[i] != digitos[j])
                {
                    palindromo = false;
                }
               
            }
            if (palindromo)
            {
                Console.WriteLine("É palindromo");
            }
            else
            {
                Console.Write(" Não é Palindromo");
            }
            Console.ReadLine();

             

        }
    }
}
