using FactoryMethod.FactoryMethod.Abstracts;
using FactoryMethod.FactoryMethod.Contracts;

namespace FactoryMethod.FactoryMethod.Creators
{
    public class TetrisCreator : GameCreator
    {
        public override IGame CreateGame()
        {
            return new Tetris();
        }
    }
}
