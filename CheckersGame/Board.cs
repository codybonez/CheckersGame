using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CheckersGame
{
    public class Board
    {
        bool isPieceColorOnBlackSquare;
        int[,] CheckerBoard = new int[8, 8];
        Boardcolor Boardcolor1 = Boardcolor.Red;
        Boardcolor Boardcolor2 = Boardcolor.Black;
        

        public Board(int[,] checkerboard)
        {
            checkerboard = this.CheckerBoard;
          

        }

        public int[,] InitializeBoard(int[,] board, List<Pieces> pieces)
        {
            int current;
            int next;
           // loop through board
           // Assign each square a color [ black or red ]
           // Add pieces to the black squares
           // do the same for other side

            // show in console

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
             

                }
            }

            return board;
        }
    }
}
