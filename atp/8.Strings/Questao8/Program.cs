using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            string[] sujeito = { "eu", "tu", "ele", "nós", "vós", "eles" };
            string[] presente = { "o", "as", "a", "amos", "ais", "am" };
            string[] preterito = { "ei", "aste", "ou", "amos", "astes", "aram" };
            string[] futuro = { "arei", "arás", "ará", "aremos", "areis", "arão" };

            do
            {
                Console.Write("Verbo: ");
                string verbo = Console.ReadLine();
                verbo = verbo.ToLower();
          
                if (verbo.EndsWith("ar"))
                {
                    Console.WriteLine("Presente do indicativo");
                    for(int i = 0; i < sujeito.Length; i++)
                    {
                        Console.WriteLine(sujeito[i] +" "+ verbo.Replace("ar", presente[i]));
                    }
                    Console.WriteLine();
                    Console.WriteLine("Pretérito perfeito do indicativo");
                    for (int i = 0; i < sujeito.Length; i++)
                    {
                        Console.WriteLine(sujeito[i] + " " + verbo.Replace("ar", preterito[i]));
                    }
                    Console.WriteLine();
                    Console.WriteLine("Futuro do presente do indicativo");
                    for (int i = 0; i < sujeito.Length; i++)
                    {
                        Console.WriteLine(sujeito[i] + " " + verbo.Replace("ar", futuro[i]));
                    }

                }
                else { Console.Write("Erro"); }
                Console.WriteLine("\nDeseja informar um novo verbo? s/n");
                op = char.Parse(Console.ReadLine());
            }
            while (op == 's');
            Console.ReadLine();
            
        }
    }
}
