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
            double dist, peso, precototal;
            const int pkm = 1;
            string URG;

            Console.WriteLine("Qual a distância? ");
            dist = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o peso? ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("A entrega é urgente? s/n ");
            URG = Console.ReadLine();

            if ((dist <= 5) && (peso <= 20))
            {
                precototal = dist * pkm;
                precototal *= 1.2;

                if (URG == "s" || URG == "S")
                {
                    precototal *= 1.3;
                }
                Console.WriteLine("Moto: R$: " + precototal);
            }
            else
            {
                Console.WriteLine("Moto: inválido");
            }

            if (peso <= 1000)
            {
                precototal = dist * pkm;
                if (URG == "s" || URG == "S")
                {
                    precototal *= 1.7;
                }
                Console.WriteLine("Van: R$: " + precototal);
            }
            else
            {
                Console.WriteLine("Van: inválido");
            }

            if (peso > 0)
            {
                precototal = dist * pkm;
                if (URG == "s" || URG == "S")
                {
                    precototal *= 2.0;
                }
                Console.WriteLine("Caminhão: R$: " + precototal);
            }
            else
            {
                Console.WriteLine("Caminhão: inválido");
            }



        }
    }
}
