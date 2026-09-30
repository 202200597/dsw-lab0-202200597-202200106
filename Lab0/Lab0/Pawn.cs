using System;
using System.Collections.Generic;
using System.Text;

namespace Lab0
{
    public class Pawn : Piece
    {
        public Pawn(Color color, Position position)
            : base(position, color)
        {
        }

        public override string Name
        {
            get { return "Pawn"; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
