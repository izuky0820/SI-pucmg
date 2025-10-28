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
            char[,] jogo = { { '-', '-', '-'}, { '-', '-', '-' }, { '-', '-', '-' } };
            char jogador1= 'x', jogador2='o';

            bool venceu = false;
            int l, c, jogada = 0;
            while (!venceu && jogada < 9)
            {
               
                do
                {
                    Console.WriteLine("Jogador 1:");
                    l = int.Parse(Console.ReadLine());
                    c = int.Parse(Console.ReadLine());
                } while (l < 0 || l > 2 || c < 0 || c > 2 || jogo[l, c] != '-');
                jogo[l, c] = jogador1;

                for (int i = 0; i < jogo.GetLength(0); i++)
                {
                    for (int j = 0; j < jogo.GetLength(1); j++)
                    {
                        Console.Write(jogo[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                for(int i = 0; i < jogo.GetLength(0); i++)
                {
                    if (jogo[i,0] == jogador1 && jogo[i,1] == jogador1 && jogo[i,2] == jogador1)
                    {
                        venceu = true;
                        Console.Write("Jogador 1 venceu");
                        
                    }
                }

                for (int j = 0; j < jogo.GetLength(1); j++)
                {
                    if (jogo[0, j] == jogador1 && jogo[1, j] == jogador1 && jogo[2, j] == jogador1)
                    {
                        venceu = true;
                        Console.Write("Jogador 1 venceu");
                       
                    }
                }

              
                if ((jogo[0, 0] == jogador1 && jogo[1, 1] == jogador1 && jogo[2, 2] == jogador1) || (jogo[0, 2] == jogador1 && jogo[1, 1] == jogador1 && jogo[2, 0] == jogador1))
                   {
                        venceu = true;
                        Console.Write("Jogador 1 venceu");
                   }
                jogada++;
                if (venceu || jogada == 9) { break; }

                do
                {

                    Console.WriteLine("Jogador 2:");
                    l = int.Parse(Console.ReadLine());
                    c = int.Parse(Console.ReadLine());
                } while (l < 0 || l > 2 || c < 0 || c > 2 || jogo[l, c] != '-');
                jogo[l, c] = jogador2;

                for (int i = 0; i < jogo.GetLength(0); i++)
                {
                    for (int j = 0; j < jogo.GetLength(1); j++)
                    {
                        Console.Write(jogo[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < jogo.GetLength(0); i++)
                {
                    if (jogo[i, 0] == jogador2 && jogo[i, 1] == jogador2 && jogo[i, 2] == jogador2)
                    {
                        venceu = true;
                        Console.Write("Jogador 2 venceu");
                        
                    }
                }

                for (int j = 0; j < jogo.GetLength(1); j++)
                {
                    if (jogo[0, j] == jogador2 && jogo[1, j] == jogador2 && jogo[2, j] == jogador2)
                    {
                        venceu = true;
                        Console.Write("Jogador 2 venceu");
                      
                    }
                }


                if ((jogo[0, 0] == jogador2 && jogo[1, 1] == jogador2 && jogo[2, 2] == jogador2) || (jogo[0, 2] == jogador2 && jogo[1, 1] == jogador2 && jogo[2, 0] == jogador2))

                {
                    venceu = true;
                    Console.Write("Jogador 2 venceu");

                }
                jogada++;
            }
            if (!venceu) { Console.Write("Deu velha"); }




        }
    }
}
