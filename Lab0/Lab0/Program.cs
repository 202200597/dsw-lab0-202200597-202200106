using Lab0;

namespace Lab0
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pawn pawn = new Pawn(
                Color.White,
                new Position(0, 2)
            );


            Rook rook = new Rook(
                Color.Black,
                new Position(0, 7)
            );

            Console.WriteLine("=== Peão ===");
            Console.WriteLine($"Nome: {pawn.Name}");
            Console.WriteLine($"Símbolo: {pawn.Symbol}");
            Console.WriteLine($"Cor: {pawn.Color}");
            Console.WriteLine($"É branco? {pawn.IsWhite}");
            Console.WriteLine($"É preto? {pawn.IsBlack}");
            Console.WriteLine($"Posição inicial: {pawn.Position}");

            pawn.Move(0, 2);

            Console.WriteLine($"Depois de Move(0, 2): {pawn.Position}");

            Console.WriteLine();

            Console.WriteLine("=== Torre ===");
            Console.WriteLine($"Nome: {rook.Name}");
            Console.WriteLine($"Símbolo: {rook.Symbol}");
            Console.WriteLine($"Cor: {rook.Color}");
            Console.WriteLine($"É branca? {rook.IsWhite}");
            Console.WriteLine($"É preta? {rook.IsBlack}");
            Console.WriteLine($"Posição inicial: {rook.Position}");

            rook.Move(3, 0);

            Console.WriteLine($"Depois de Move(3, 0): {rook.Position}");

            rook.Move(0, -2);

            Console.WriteLine($"Depois de Move(0, -2): {rook.Position}");

            rook.Move(2, 2);

            Console.WriteLine($"Depois de Move(2, 2): {rook.Position}");
        }
    }
}
