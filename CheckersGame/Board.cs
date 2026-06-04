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

                    else if (i == 3 && squareColor == Square.squareColor.Grey || i == 4 && squareColor == Square.squareColor.Grey)
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



                  else if (i >= 5 && i <= 8 && squareColor == Square.squareColor.Grey)
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

                    if (j == col - 1 && squareColor == Square.squareColor.Grey)
                    {
                        squareColor = Square.squareColor.Red;
                    }
                    else if (j == col - 1 && squareColor == Square.squareColor.Red)
                    {
                        squareColor = Square.squareColor.Grey;
                    }









                }
            }




        }


        public void Showgame()
        {
            // top part
            for (int n = 5; n < 8; n++)
            {
                for (int o = 0; o < 8; o++)
                {
                    
                    Console.Write(gameBoard[n, o].Squarecolor == Square.squareColor.Grey && gameBoard[n, o].piece.piececolor == Pieces.pieceColor.White ? $"[-]" : $"[ ]");

                    if (o == 7) Console.WriteLine("\r");

                   
                    // use ternary operator to make custom black and white pieces and board

                }
            }




            // empty part
            for (int l = 0; l < 2; l++)
            {
                for (int m = 0; m < 8; m++)
                {
                    Console.Write(gameBoard[l, m].Squarecolor == Square.squareColor.Grey && gameBoard[l, m].piece.piececolor == Pieces.pieceColor.None ? $"[ ]" : $"[ ]");

                    if (m == 7) Console.WriteLine("\r");


                    // use ternary operator to make custom black and white pieces and board

                }
            }

            // black pieces show 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(gameBoard[i, j].Squarecolor == Square.squareColor.Grey  && gameBoard[i,j].piece.piececolor == Pieces.pieceColor.Black ? $"[-]" : $"[ ]");
    
                    if (j == 7) Console.WriteLine("\r");
                 

                    // use ternary operator to make custom black and white pieces and board

                }
            }

          
        }

    }


    

    
}
