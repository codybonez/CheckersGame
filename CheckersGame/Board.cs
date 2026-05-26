using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CheckersGame
{
    public class Board
    {
        Square[,] gameBoard;
        Square.squareColor? squareColor = Square.squareColor.Grey;
        Pieces.pieceColor? pieceColor = Pieces.pieceColor.Black;
        Pieces.pieceStatus status = Pieces.pieceStatus.None;
        public Board(int row, int col)
        {

            // loop through board
            // Assign each square a color [ black or red ]
            // Add pieces to the black squares
            // do the same for other side

            // show in console

      
         
            gameBoard = new Square[row, col];



            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    gameBoard[i, j] = new Square();
                    gameBoard[i, j].piece = new Pieces();
                    gameBoard[i, j].Squarecolor = squareColor;
                    gameBoard[i, j].status = status;








                    // skip rows for pieces

                    if (i <= 2 && squareColor == Square.squareColor.Grey)
                    {
            
                        
                   
                            gameBoard[i, j].piece.piececolor = pieceColor;
                            status = Pieces.pieceStatus.Man;
                        gameBoard[i, j].piece.status = status;
                        squareColor = Square.squareColor.Red;
               

                    }
                    else if (i <= 2 && squareColor == Square.squareColor.Red)
                    {
                        
                            
                        
                       
                            gameBoard[i, j].piece.piececolor = pieceColor;

                        status = Pieces.pieceStatus.None;
                        gameBoard[i, j].piece.status = status;
                        squareColor = Square.squareColor.Grey;
                    
                        
                    }

                     if (i == 3 && squareColor == Square.squareColor.Grey || i == 4 && squareColor == Square.squareColor.Grey)
                    {

                        status = Pieces.pieceStatus.None;

                        gameBoard[i, j].piece.status = status;

                        pieceColor = Pieces.pieceColor.None;

                        gameBoard[i, j].piece.piececolor = pieceColor;

                        squareColor = Square.squareColor.Red;

                      

                    }
                    else if (i == 3 && squareColor == Square.squareColor.Red || i == 4 && squareColor == Square.squareColor.Red)
                    {

                        status = Pieces.pieceStatus.None;

                        gameBoard[i, j].piece.status = status;

                        pieceColor = Pieces.pieceColor.None;

                        gameBoard[i, j].piece.piececolor = pieceColor;

                        squareColor = Square.squareColor.Grey;
                       
                    }



                     if (i >= 5 && i <= 8 && squareColor == Square.squareColor.Grey)
                    {


                        pieceColor = Pieces.pieceColor.White;
                        gameBoard[i, j].piece.piececolor = pieceColor;
                        status = Pieces.pieceStatus.Man;
                        gameBoard[i, j].piece.status = status;
                        squareColor = Square.squareColor.Red;

                    }
                    else if (i >= 5 && i <= 8 && squareColor == Square.squareColor.Red)
                    {


                        status = Pieces.pieceStatus.None;
                        gameBoard[i, j].piece.status = status;
                        pieceColor = Pieces.pieceColor.White;
                        gameBoard[i, j].piece.piececolor = pieceColor;
                        squareColor = Square.squareColor.Grey;

                    }







                  



                    }
            }




        }


        public void Showgame()
        {
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine($" board color [{gameBoard[i, j].Squarecolor}] at {i + 1} {j + 1}");
                    Console.WriteLine($" piece color [ {gameBoard[i, j].piece.piececolor} ] at {i+1} {j+1}");
                    
                    Console.WriteLine($" piece status [ {gameBoard[i, j].piece.status} ] at {i+1} {j+1}");
                    Console.WriteLine('\n');
                }
            }

        }

    }


    

    
}
