using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace questao10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A, B;
            do
            {
                Console.Write("Frase: ");
                A = Console.ReadLine();
                if (A.Length > 50) { Console.Write("Erro"); }
            }
            while (A.Length > 50);
            do
            {
                Console.Write("informe dois caracteres: ");
                B = Console.ReadLine();

                if (B.Length != 2)
                {
                    Console.WriteLine("Erro");
                }

            }
            while (B.Length != 2);


            int cont = 0, c = 0;


            while ((c = A.IndexOf(B, c)) != -1)
            {
                cont++;
                c += B.Length; 
            }

            Console.WriteLine($"A string \"{B}\" aparece {cont} vezes na frase.");

        }
    }
}
