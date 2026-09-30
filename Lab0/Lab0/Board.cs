using System;
using System.Collections.Generic;
using System.Text;

namespace Lab0
{
    public class Board
    {
        private Piece[,] pieces;

        public Board()
        {
            pieces = new Piece[8, 8];

            for (int x = 0; x < 8; x++)
            {
                pieces[x, 1] = new Pawn(
                    Color.White,
                    new Position(x, 1)
                );
            }

            for (int x = 0; x < 8; x++)
            {
                pieces[x, 6] = new Pawn(
                    Color.Black,
                    new Position(x, 6)
                );
            }

            pieces[0, 0] = new Rook(
                Color.White,
                new Position(0, 0)
            );

            pieces[7, 0] = new Rook(
                Color.White,
                new Position(7, 0)
            );

            pieces[0, 7] = new Rook(
                Color.Black,
                new Position(0, 7)
            );

            pieces[7, 7] = new Rook(
                Color.Black,
                new Position(7, 7)
            );
        }

        public void Show()
        {
            Console.WriteLine("----a---b---c---d---e---f---g---h----");
            Console.WriteLine("--+---+---+---+---+---+---+---+---+--");

            for (int y = 7; y >= 0; y--)
            {
                Console.Write($"{y + 1} |");

                for (int x = 0; x < 8; x++)
                {
                    if (pieces[x, y] == null)
                    {
                        Console.Write("   |");
                    }
                    else
                    {
                        Console.Write($" {pieces[x, y].Symbol} |");
                    }
                }

                Console.WriteLine($" {y + 1}");
                Console.WriteLine("--+---+---+---+---+---+---+---+---+--");
            }

            Console.WriteLine("----a---b---c---d---e---f---g---h----");
        }
    }
}
