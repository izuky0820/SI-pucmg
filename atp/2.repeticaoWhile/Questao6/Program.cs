using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op=1, meses;
            double salario=0;
       

            do
            {
                
                Console.WriteLine("\nMenu de opções:\r\n1. Novo salário\r\n2. Férias\r\n3. Décimo terceiro\r\n4. Sair");
                Console.Write("Escolha um opção: ");
                op = int.Parse(Console.ReadLine());
                if (op == 1 || op == 2 || op == 3)
                {
                    do
                    {
                        Console.Write("Informe seu salario: ");
                        salario = double.Parse(Console.ReadLine());
                    }
                    while (salario <= 0);
                }

                switch (op)
                {
                    case 1:
                        if (salario <= 999.99)
                        {
                            Console.WriteLine($"Seu novo salário é: {(salario + salario * 0.15):F2}");

                        }
                        else if (salario >= 1000.00 && salario <= 2000.00)
                        {
                            Console.WriteLine($"Seu novo salário é: {(salario + salario * 0.10):F2}");

                        }
                        else
                        {
                            Console.WriteLine($"Seu novo salário é: {(salario + salario * 0.05):F2}");

                        }
                        break;
                    case 2:
                        Console.WriteLine($"Férias: {(salario + (salario / 3)):F2}");

                        break;


                    case 3:
                        do
                        {
                            Console.WriteLine("Informe a quantidade de meses trabalhados: ");
                            meses = int.Parse(Console.ReadLine());
                            if (meses > 12)
                            {
                                Console.WriteLine("Valor inválido");
                            }
                            else
                            {
                                Console.WriteLine($"Décimo terceiro: {((salario * meses) / 12):F2}");

                            }


                        }
                        while (meses > 12);
                        break;
                    case 4:
                        Console.WriteLine("Fim do programa");
                        break;
                    default:
                        Console.Write("Opção inválida");
                        break;


                }



            }
            while (op != 4);
            Console.ReadLine();
        }
    }
}
