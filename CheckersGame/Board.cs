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
       
                    if (squareColor == Square.squareColor.Grey)
                    {
                       
                        squareColor = Square.squareColor.Red;
                      var black_piece = gameBoard[i, j].piece.piece_ColorBlack;
                    }
                    else
                    {
                        squareColor = Square.squareColor.Grey;
                        
                    }

                    Console.WriteLine($"Current square color of {i + 1} {j + 1} is {gameBoard[i, j].color}");
                    Console.WriteLine("\n");
                    Console.WriteLine($"Current piece color of {i + 1} {j + 1} is {gameBoard[i,j].pieceColor}");

                    
                }
            }




        }




    

    }
}
