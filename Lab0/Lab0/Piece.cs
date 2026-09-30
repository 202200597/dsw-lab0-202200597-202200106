using System;
using System.Collections.Generic;
using System.Text;

namespace Lab0
{
    public abstract class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; set; }

        public virtual string Name
        {
            get { return "Desconhecida"; }
        }

        public Piece()
        {
            Position = new Position();
            Color = Color.White;
        }

        public Piece(Position position, Color color)
        {
            Position = position;
            Color = color;
        }

        public override string ToString()
        {
            return Position.ToString();
        }
    }
}
