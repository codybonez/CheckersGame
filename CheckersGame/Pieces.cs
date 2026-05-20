using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    public class Pieces
    {
        // add piece status next
        public pieceColor piece_ColorBlack = Pieces.pieceColor.Black;
        public pieceColor piece_ColorWhite = Pieces.pieceColor.White;
        public pieceStatus Man = pieceStatus.Man;
        public pieceStatus King = pieceStatus.King;
        public enum pieceStatus
        {
            Man, 
            King
        }
        public enum pieceColor
        {
            Black = 0,
            White = 1
        }

        public Pieces() { 
        
        }

    }
}
