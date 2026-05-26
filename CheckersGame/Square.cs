using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    public class Square
    {
        public Pieces? piece;
        public squareColor? Squarecolor;
   
        public Pieces.pieceStatus? status;
        public bool isSquareColorBlack;
        public bool isSquareColorRed;
        public enum squareColor
        {
            Red = 0,

            Grey = 1
        }

    }
}
