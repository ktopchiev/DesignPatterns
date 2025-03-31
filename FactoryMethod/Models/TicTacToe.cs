using FactoryMethod.Contracts;

namespace FactoryMethod.Models
{
    public class TicTacToe : IGame
    {
        public string Play() => "You're playing TicTacToe now!\n";
    }
}
