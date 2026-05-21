using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CheckersGame
{
    public class Board
    {



        public Board(int row, int col)
        {

            // loop through board
            // Assign each square a color [ black or red ]
            // Add pieces to the black squares
            // do the same for other side

            // show in console

            Square[,] gameBoard = new Square[row, col];
            Square.squareColor? squareColor = Square.squareColor.Grey;
            Pieces.pieceColor? pieceColor = Pieces.pieceColor.Black;


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    gameBoard[i, j] = new Square();
                    gameBoard[i, j].piece = new Pieces();
                    gameBoard[i, j].color = squareColor;
                    var black_piece = gameBoard[i, j].piece.piece_ColorBlack;
                    var white_piece = gameBoard[i, j].piece.piece_ColorWhite;








                    // skip rows for pieces
                    if (i == 4 || i == 5)
                    {
                        gameBoard[i, j].piece = null;
                    }
                    else if (i <= 3 && squareColor == Square.squareColor.Grey)
                    {
                        gameBoard[i, j].piece.piece_ColorBlack = black_piece;
                        squareColor = Square.squareColor.Red;

                    }
                    else if (i <= 3 && squareColor == Square.squareColor.Red)
                    {
                        gameBoard[i, j].piece.piece_ColorBlack = black_piece;
                        squareColor = Square.squareColor.Grey;
                    }
                    if (i >= 6 && i <= 8 && squareColor == Square.squareColor.Grey)
                    {
                        gameBoard[i, j].piece.piece_ColorWhite = white_piece;
                        squareColor = Square.squareColor.Red;
                    }
                    else if (i >= 6 && i <= 8 && squareColor == Square.squareColor.Red)
                    {
                        gameBoard[i, j].piece.piece_ColorWhite = white_piece;
                        squareColor = Square.squareColor.Grey;
                    }







                  ;
                  


                }
            }




        }

    }


    

    
}
