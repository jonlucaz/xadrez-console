using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('e',2);


            Console.WriteLine(pos);

            Console.WriteLine();
            Console.WriteLine(pos.toPosicao());
        }
    }
}