using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao11
{
    internal class Program
    {
        static void ConverterSegundos(int totalSegundos, out int hora, out int min, out int seg)
        {
            hora = totalSegundos / 3600;
            min = (totalSegundos % 3600) / 60;
            seg = totalSegundos % 60;
        }
        static void Main(string[] args)
        {
            int segundos, h, m, s;
            Console.Write("Informe os segundos para conversão: ");
            segundos = int.Parse(Console.ReadLine());
            ConverterSegundos(segundos, out h, out m, out s);
            Console.Write($"{h}:{m}:{s}");
        }
    }
}
