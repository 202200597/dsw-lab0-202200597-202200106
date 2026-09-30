using System;
using System.Collections.Generic;
using System.Text;

namespace Lab0
{
    public class Rook : Piece
    {
        public Rook(Color color, Position position)
            : base(position, color)
        {
        }

        public override string ToString()
        {
            return $"T{base.ToString()}";
        }
    }
}
