using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, empresa, cargo;
            double salario, desconto=0, liquido=0;
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Empresa: ");
            empresa = Console.ReadLine();
            Console.Write("Cargo: ");
            cargo = Console.ReadLine();
            Console.Write("Salario: ");
            salario = double.Parse(Console.ReadLine());
            if (salario <= 1518.00)
            {
                desconto = salario * 0.075;
                liquido = salario - desconto;
                
            }
            else if ((salario > 1518.00) && (salario <= 2793.88))
            {
                desconto = (salario * 0.09) - 22.7;
                liquido = salario - desconto;
              
            }
            else if ((salario >= 2793.89 ) && (salario <= 4190.83))
            {
                desconto = (salario * 0.12) - 106.59;
                liquido = salario - desconto;
              
            }
            else if ((salario >= 4190.84) && (salario <= 8157.41))
            {
                desconto = (salario * 0.14) - 106.9;
                liquido = salario - desconto;
            
            }
            else if (salario > 8157.41)
            {
                liquido = salario - 1209.59;
            }
            else
            {
                Console.WriteLine("Informções inválidas");
            }
            Console.WriteLine("Nome:" + nome + "\nEmpresa: " + empresa + "\nCargo: " + cargo);
            Console.WriteLine("Com desconto de R$" + desconto + ", seu salário líquido é R$" + liquido);

            Console.ReadLine();
        }
    }
}
