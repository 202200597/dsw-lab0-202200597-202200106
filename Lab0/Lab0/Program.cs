using Lab0;

namespace Lab0
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pawn pawn = new Pawn(
                Color.White,
                new Position(0, 1)
            );

            Rook rook = new Rook(
                Color.Black,
                new Position(0, 7)
            );

            Console.WriteLine($"Peão: {pawn}");
            Console.WriteLine($"Cor do peão: {pawn.Color}");
            Console.WriteLine($"Posição do peão: {pawn.Position}");

            Console.WriteLine();

            Console.WriteLine($"Torre: {rook}");
            Console.WriteLine($"Cor da torre: {rook.Color}");
            Console.WriteLine($"Posição da torre: {rook.Position}");
        }
    }
}
