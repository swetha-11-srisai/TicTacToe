using System;

namespace TicTacToeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TicTacToeGame tic = new TicTacToeGame();
            tic.Check();
        }
    }
}
