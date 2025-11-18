using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Questao9
{
    internal class Program
    {
        static string Email(string nome)
        {
            nome = nome.ToLower();
            string[] vet = nome.Split(' ');
            string email = vet[0] + '.' + vet[vet.Length - 1] + "@acme.br";
            return email;
        }
        static void Main(string[] args)
        {
            Console.Write("Nome completo: ");
            string nome = Console.ReadLine();
            string email = Email(nome);
            Console.Write(email);
            Console.ReadLine();
        }
    }
}
