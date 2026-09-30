using System;
using System.Collections.Generic;
using System.Text;

namespace Lab0
{
    public abstract class Piece: IMovable
    {
        public Position Position { get; set; }
        public Color Color { get; set; }

        public virtual string Name
        {
            get { return "Desconhecida"; }
        }

        public bool IsWhite
        {
            get { return Color == Color.White; }
        }

        public bool IsBlack
        {
            get { return Color == Color.Black; }
        }

        public virtual string Symbol
        {
            get { return "?"; }
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

        public abstract void Move(int dx, int dy);
    }
}
