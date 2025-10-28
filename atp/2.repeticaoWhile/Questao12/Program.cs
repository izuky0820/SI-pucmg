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
            double A = 10000, B = 30000, h=0;
            while (B >= A)
            {
                A += (A * 0.5);
                B += (B * 0.4);
                h++;
            }
            Console.WriteLine($"O número de bactérias da colônia A foi de {A} e de B foi {B} depois de {h} horas.");
        }
    }
}
