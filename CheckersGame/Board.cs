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
     
        

        public Board(int[,] checkerboard)
        {
            this.CheckerBoard = checkerboard;


        }

        public int[,] InitializeBoard(int[,] board, List<Pieces> pieces)
        {
           
            return board;
        }
    }
}
