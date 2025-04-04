using Creational.FactoryMethod.Contracts;

namespace Creational.FactoryMethod.Models
{
    public class Tetris : IGame
    {
        public string Play() => "You're playing Tetris now!\n";
    }
}
