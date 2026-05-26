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


        public Board(int row, int col)
        {

            // loop through board
            // Assign each square a color [ black or red ]
            // Add pieces to the black squares
            // do the same for other side

            // show in console

      
            Square.squareColor? squareColor = Square.squareColor.Grey;
            Pieces.pieceColor? pieceColor = Pieces.pieceColor.Black;
            gameBoard = new Square[row, col];



            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    gameBoard[i, j] = new Square();
                    gameBoard[i, j].piece = new Pieces();
                    gameBoard[i, j].color = squareColor;
                  
                    var status = Pieces.pieceStatus.Man;







                    // skip rows for pieces

                     if (i <= 3 && squareColor == Square.squareColor.Grey)
                    {
                        if (i == 4 || i == 5)
                        {
                            status = Pieces.pieceStatus.None;
                            gameBoard[i, j].piece.status = status;
                            pieceColor = Pieces.pieceColor.None;
                            gameBoard[i, j].piece.piececolor = pieceColor;

                        }
                        else
                        {
                            gameBoard[i, j].piece.piececolor = pieceColor;
                            gameBoard[i, j].status = status;
                            squareColor = Square.squareColor.Red;
                           
                        }

                    }
                    else if (i <= 3 && squareColor == Square.squareColor.Red)
                    {
                        if (i == 4 || i == 5)
                        {
                            status = Pieces.pieceStatus.None;
                            gameBoard[i, j].piece.status = status;
                            pieceColor = Pieces.pieceColor.None;
                            gameBoard[i, j].piece.piececolor = pieceColor;
                        }
                        else
                        {
                            gameBoard[i, j].piece.piececolor = pieceColor;
                            gameBoard[i, j].status = status;
                            squareColor = Square.squareColor.Grey;
                        }
                    }
                    if (i >= 6 && i <= 8 && squareColor == Square.squareColor.Grey)
                    {
                        if (i == 4 || i == 5)
                        {
                            status = Pieces.pieceStatus.None;
                            gameBoard[i, j].piece.status = status;
                            pieceColor = Pieces.pieceColor.None;
                            gameBoard[i, j].piece.piececolor = pieceColor;
                        }
                        else
                        {
                            pieceColor = Pieces.pieceColor.White;
                            gameBoard[i, j].piece.piececolor = pieceColor;
                            gameBoard[i, j].status = status;

                            squareColor = Square.squareColor.Red;
                        }
                    }
                    else if (i >= 6 && i <= 8 && squareColor == Square.squareColor.Red)
                    {
                        if (i == 4 || i == 5)
                        {
                            status = Pieces.pieceStatus.None;
                            gameBoard[i, j].piece.status = status;
                            pieceColor = Pieces.pieceColor.None;
                            gameBoard[i, j].piece.piececolor = pieceColor;
                        }
                        else
                        {
                            gameBoard[i, j].status = status;
                            pieceColor = Pieces.pieceColor.White;
                            gameBoard[i, j].piece.piececolor = pieceColor;
                            squareColor = Square.squareColor.Grey;
                        }
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
                    Console.WriteLine($"[ {gameBoard[i, j].piece.piececolor} ] at {i} {j}");
                }
            }

        }

    }


    

    
}
