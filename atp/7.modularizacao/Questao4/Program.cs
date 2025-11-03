using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4
    /*04. Escreva um método que receba como parâmetros 3 números inteiros e uma letra(char). Se a letra for ‘A’,
o método deve calcular e escrever a média aritmética dos valores recebidos como parâmetros.Se a letra for
‘P’, o método deve imprimir a média ponderada, usando os seguintes pesos: 5, 3 e 2. Para outras letras, o
procedimento deve exibir uma mensagem indicando que não é possível fazer nenhum cálculo.*/


{
    internal class Program
    {
        static void VerificaLetra(int a, int b, int c, char letra)
        {
            switch (letra)
            {
                case 'A':
                    Console.Write((a + b + c) / 3);
                    break;
                case 'P':
                    Console.Write((a * 5 + b * 3 + c * 2) / 5 + 3 + 2);
                    break;
                default:
                    Console.Write("Não é possível fazer nenhum cálculo");
                    break;
            }
        }

        static void Main(string[] args)
        {
            int num1, num2, num3;
            char l;
            Console.WriteLine("Informe três números: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe uma letra: ");
            l = char.Parse(Console.ReadLine());
            VerificaLetra(num1, num2, num3, l);
            Console.ReadLine();

        }
    }
}
