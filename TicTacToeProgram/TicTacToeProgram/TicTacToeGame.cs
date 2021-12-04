using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeProgram
{
    class TicTacToeGame
    {
          char[] game = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
           
        public void Check()
        {
           for(int i = 1; i < game.Length; i++)
            {
                game[i] = ' ';
            }

        }

       
    }
}
