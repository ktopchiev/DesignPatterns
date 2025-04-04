using FactoryMethod.FactoryMethod.Abstracts;
using FactoryMethod.FactoryMethod.Contracts;

namespace FactoryMethod.FactoryMethod.Creators
{
    public class TicTacToeCreator : GameCreator
    {
        public override IGame CreateGame()
        {
            return new TicTacToe();
        }
    }
}
