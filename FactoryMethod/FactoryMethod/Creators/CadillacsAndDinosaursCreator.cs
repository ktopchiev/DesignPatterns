using Creational.FactoryMethod.Abstracts;
using Creational.FactoryMethod.Contracts;
using Creational.FactoryMethod.Models;

namespace Creational.FactoryMethod.Creators
{
    public class CadillacsAndDinosaursCreator : GameCreator
    {
        public override IGame CreateGame()
        {
            return new CadillacsAndDinosaurs();
        }
    }
}
