using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double num, result;
            Console.WriteLine("Escolha uma opção: \r\n1. Converter de centímetros para metros\r\n2. Converter de metros para centímetros\r\n3. Converter de milímetros para metros\r\n4. Converter de metros para milímetros ");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número: ");
            num = double.Parse(Console.ReadLine());
            
            switch (opcao)
            {
                case 1:
                    result = num / 100;
                    Console.Write(result);
                    break;
                case 2:
                    result = num * 100;
                    Console.Write(result);
                    break;
                case 3:
                    result = num / 1000;
                    Console.Write(result);
                    break;
                case 4:
                    result = num * 1000;
                    Console.Write(result);
                    break;
                default:
                    Console.Write("Opção inválida");
                    break;
            }
            Console.ReadLine();
        }
    }
}
