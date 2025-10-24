using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op = 's';
            int qtd = 0, sal5000 = 0, anos15 = 0, somaAnos = 0;
            double somaSal = 0, maxSal = double.MinValue;

            while (op == 's' || op == 'S')
            {
                qtd++;

                Console.Write("Informe o salário: ");
                double sal = double.Parse(Console.ReadLine());
                somaSal += sal;

                if (sal <= 5000) sal5000++;
                if (sal > maxSal) maxSal = sal;

                Console.Write("Informe os anos de estudo: ");
                int anos = int.Parse(Console.ReadLine());
                somaAnos += anos;

                if (anos >= 15) anos15++;

                Console.Write("Deseja informar dados de mais habitantes? (s/n): ");
                op = char.Parse(Console.ReadLine());
            }
            // média dos salários
            Console.WriteLine($"Média salários: {somaSal / qtd}");
            // média dos anos
            Console.WriteLine($"Média anos de estudo: {(double)somaAnos / qtd}");
            // maior salário
            Console.WriteLine($"Maior salário: {maxSal}");
            // porcentagem salário < 5000
            Console.WriteLine($"% salário <= 5000: {(double)sal5000 / qtd * 100}%");
            // porcentagem anos de est
            Console.WriteLine($"% anos estudo >= 15: {(double)anos15 / qtd * 100}%");










        }
    }
}
