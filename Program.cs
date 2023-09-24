namespace MyNameSpace
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
        }
    }
    class Game
    {
        public Game()
        {
            Console.WriteLine("Game started");
        }
        ~Game()
        {
            Console.WriteLine("Game finished");
        }
    }
}