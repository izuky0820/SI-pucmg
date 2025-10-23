using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i1, i2, i3;
            Console.Write("Informe a primeira idade: ");
            i1 = int.Parse(Console.ReadLine());
            Console.Write("Informe a segunda idade: ");
            i2= int.Parse(Console.ReadLine());
            Console.Write("Informe a terceira idade: ");
            i3= int.Parse(Console.ReadLine());

            if (i1 == i2 || i1 == i3 || i2 == i3)
            {
                Console.WriteLine("Existem idades iguais, informe apenas idades diferentes :)");
            }

            else
            {

                if ((i1 > i2) && (i1 > i3))
                {
                    Console.WriteLine(i1);
                }
                else if ((i2 > i1) && (i2 > i3))
                {
                    Console.WriteLine(i2);
                }
                else
                {
                    Console.WriteLine(i3);
                }


                if ((i1 < i2) && (i1 < i3))
                {
                    Console.WriteLine(i1);
                }
                else if ((i2 < i1) && (i2 < i3))
                {
                    Console.WriteLine(i2);
                }
                else
                {
                    Console.WriteLine(i3);
                }
            }


           

            Console.ReadLine();




        }
    }
}
