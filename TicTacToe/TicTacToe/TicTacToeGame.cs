using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int player = 1;
        int choice;
        public void Check()
        {
            Console.WriteLine("player1:X and Player2:O");
            if (player % 2 == 0)
            {
                Console.WriteLine("Player 2 chance");
            }
            else
            {
                Console.WriteLine("Player 1 chance");
            }
        }
    }
}
