using FactoryMethod.Abstracts;
using FactoryMethod.Contracts;

namespace FactoryMethod.Creators
{
    public class TetrisCreator : GameCreator
    {
        public override IGame CreateGame()
        {
            return new Tetris();
        }
    }
}
