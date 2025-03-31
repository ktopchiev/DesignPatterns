using FactoryMethod.Contracts;

namespace FactoryMethod.Creators
{
    public class TicTacToeCreator : GameCreator
    {
        public override IGame CreateGame()
        {
            return new TicTacToe();
        }
    }
}
