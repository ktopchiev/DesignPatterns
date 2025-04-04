using Creational.FactoryMethod.Abstracts;
using Creational.FactoryMethod.Contracts;
using Creational.FactoryMethod.Models;

namespace Creational.FactoryMethod.Creators
{
    public class TetrisCreator : GameCreator
    {
        public override IGame CreateGame()
        {
            return new Tetris();
        }
    }
}
