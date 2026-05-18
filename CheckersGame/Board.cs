using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CheckersGame
{
    public class Board
    {
       
        public int row;
        public int col;
        
        public Board(int _row, int _col)
        {

            // loop through board
            // Assign each square a color [ black or red ]
            // Add pieces to the black squares
            // do the same for other side

            // show in console
            this.row = _row;
            this.col = col;
            Square[,] gameBoard = new Square[_row, _col];
            
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    if (gameBoard[i,j].color == Square.squareColor.Black)
                    {
                        gameBoard[i, j].color = Square.squareColor.Black;
                        gameBoard[++i, ++j].color = Square.squareColor.Red;

                    }
                    else
                    {
                        gameBoard[i, j].color = Square.squareColor.Red;
                        gameBoard[++i, ++j].color = Square.squareColor.Black;
                    }
                   



                }
            }




        }




    

    }
}
