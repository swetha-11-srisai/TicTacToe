using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int player = 1;
        
        public void Check()
        {
            while (arr[player] < arr.Length)
            {
                player++;
            }
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
        public void ShowMethod()
        {
            Console.WriteLine("| | ");
            Console.WriteLine("{0} | {1} |{2}",arr[1],arr[2],arr[3]);
            Console.WriteLine("__|__|__");
            Console.WriteLine("| | ");
            Console.WriteLine("{0} | {1} |{2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("__|__|__");
            Console.WriteLine("| | ");
            Console.WriteLine("{0} | {1} |{2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("| | ");
        }

    }
}
