using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao5
{
    internal class Program
    {
        static bool Palindromo(string a)
        {
            bool x = true;
            for(int i = 0, j = a.Length-1; i < a.Length && j >= 0 ; i++, j--)
            {
                if (a[i] == a[j]) { x = true; }
                else { x = false; }
                
            }
            return x;

        }
        static void Main(string[] args)
        {
            Console.Write("Palavra: ");
            string str = Console.ReadLine();
            bool palindromo = Palindromo(str);
            if (palindromo) { Console.Write("É palíndromo"); }
            else { Console.Write("Não é palíndromo"); }
            Console.ReadLine();
        }
    }
}
