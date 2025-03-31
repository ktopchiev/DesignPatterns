using FactoryMethod.Contracts;

namespace FactoryMethod.Creators
{
    public class CadillacsAndDinosaursCreator : GameCreator
    {
        public override IGame CreateGame()
        {
            return new CadillacsAndDinosaurs();
        }
    }
}
