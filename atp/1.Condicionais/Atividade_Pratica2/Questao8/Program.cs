using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double litros, faturaTotal, fagua, fesgoto;
            const double agua = 305.55, esgoto = 226.05;
            fagua = agua;
            fesgoto = esgoto;

            Console.WriteLine("Informe o consumo em litros: ");
            litros = double.Parse(Console.ReadLine());
            double cons = litros / 1000;
            if ((cons > 0) && (cons <= 75))
            {
                fagua += cons * 2.11;
                fesgoto += cons * 1.56;
            }
            else if (cons > 75 && cons <= 150)
            {
               
                fagua += 75 * 2.11;
                fesgoto += 75 * 1.56;

               
                double excedente = cons - 75;
                fagua += excedente * 4.496;
                fesgoto += excedente * 3.327;
            }
            else if (cons > 150 && cons <= 225)
            {
                
                fagua += 75 * 2.11;
                fesgoto += 75 * 1.56;

         
                fagua += 75 * 4.496;
                fesgoto += 75 * 3.327;

             
                double excedente = cons - 150;
                fagua += excedente * 6.968;
                fesgoto += excedente * 5.156;
            }
            else if (cons > 225)
            {
            
                fagua += 75 * 2.11;
                fesgoto += 75 * 1.56;
                fagua += 75 * 4.496;
                fesgoto += 75 * 3.327;

          
                fagua += 75 * 6.968;
                fesgoto += 75 * 5.156;

               
                double excedente = cons - 225;
                fagua += excedente * 9.512;
                fesgoto += excedente * 7.039;
            }
            faturaTotal = fagua + fesgoto;
            Console.WriteLine(faturaTotal);
            Console.ReadLine();


            
           
        }
    }
}
    

