using Lab0;

namespace Lab0
{
    public class Program
    {
        static void Main(string[] args)
        {
            Position position1 = new Position();

            Position position2 = new Position(4, 6);

            Console.WriteLine($"Posição 1: {position1}");
            Console.WriteLine($"Posição 2: {position2}");
        }
    }
}
