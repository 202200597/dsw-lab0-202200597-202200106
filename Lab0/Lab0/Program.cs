using Lab0;

namespace Lab0
{
    public class Program
    {
        static void Main(string[] args)
        {
            Piece[] pieces = {

                new Pawn(Color.White, new Position(0, 1)),
                new Rook(Color.Black, new Position(0, 7)),
                new Pawn(Color.Black, new Position(4, 6)),
                new Rook(Color.White, new Position(7, 0)),
            };

            foreach (Piece piece in pieces)
            {
                Console.WriteLine($"Nome: {piece.Name} | Posição: {piece.Position}");
            }
        }
    }
}
