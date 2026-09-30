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

        public override string Name
        {
            get { return "Rook"; }
        }

        public override string Symbol
        {
            get { return "R"; }
        }

        public override void Move(int dx, int dy)
        {
            if (dx == 0 || dy == 0)
            {
                Position.X += dx;
                Position.Y += dy;
            }
        }

        public override string ToString()
        {
            return $"T{base.ToString()}";
        }
    }
}
