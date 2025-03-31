using FactoryMethod.Contracts;

namespace FactoryMethod.Models
{
    public class Tetris : IGame
    {
        public string Play() => "You're playing Tetris now!\n";
    }
}
