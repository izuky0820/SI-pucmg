using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont=0;
            double soma = 0, nota = 1;
            while(nota >= 0)
            {
                Console.Write("Informe uma nota: ");
                nota = double.Parse(Console.ReadLine());
                if (nota >= 0)
                {
                    soma += nota;
                    cont++;
                }
      

            }
           
            Console.Write($"Média: {soma / cont}");
            Console.ReadLine();

        }

    }
}
