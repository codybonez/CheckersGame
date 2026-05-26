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
        public pieceColor? piececolor = pieceColor.Black;
        public pieceStatus status = pieceStatus.Man;
      
        public enum pieceStatus
        {
            Man, 
            King,
            None
        }
        public enum pieceColor
        {
            Black = 0,
            White = 1,
            None
        }

        public Pieces() { 
        
        }

    }
}
