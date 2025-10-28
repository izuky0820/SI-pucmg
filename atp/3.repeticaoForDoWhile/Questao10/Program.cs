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
            double t;
            int op;
            do
            {
                Console.WriteLine("\nMenu\r\n1. Converter de Celsius para Fahrenheit\r\n2. Converter de Celsius para Kelvin\r\n3. Converter de Fahrenheit para Celsius\r\n4. Converter de Fahrenheit para Kelvin\r\n5. Converter de Kelvin para Celsius\r\n6. Converter de Kelvin para Fahrenheit\r\n7. Sair");

                Console.Write("Escolha: ");
                op = int.Parse(Console.ReadLine());
 
                if (op >= 1 && op <= 6)
                {
                    Console.Write("Temperatura: ");
                    t = double.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.WriteLine($"Conversão de Celsius para Fahrenheit: {(t * 9 / 5) + 32} ");
                            break;
                        case 2:
                            Console.WriteLine($"Conversão de Celsius para Kelvin: {t + 273.15} ");
                            break;
                        case 3:
                            Console.WriteLine($"Conversão de  Fahrenheit para Celsius: {(t - 32) * 5 / 9} ");
                            break;
                        case 4:
                            Console.WriteLine($"Conversão de  Fahrenheit para Kelvin: {(t - 32) * 5 / 9 + 273.15} ");
                            break;
                        case 5:
                            Console.WriteLine($"Conversão de Kelvin para Celsius: {t - 273.15} ");
                            break;
                        case 6:
                            Console.WriteLine($"Conversão de  Kelvin para Fahrenheit: {(t - 273.15) * 9 / 5 + 32} ");
                            break;
                     
                    }
                }
                else if (op == 7)
                {
                    Console.WriteLine("Fim do programa.");
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }

            }
            while (op != 7);
            Console.ReadLine();
        }
        
    }
}
