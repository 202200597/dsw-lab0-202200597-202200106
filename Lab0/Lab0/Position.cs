using System;
using System.Collections.Generic;
using System.Text;

namespace Lab0
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position()
        {
            X = 0;
            Y = 0;
        }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            char column = (char)('a' + X);
            int row = Y + 1;

            return $"{column}{row}";
        }
    }
}
