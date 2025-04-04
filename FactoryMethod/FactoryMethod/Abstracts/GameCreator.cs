using FactoryMethod.FactoryMethod.Contracts;

namespace FactoryMethod.FactoryMethod.Abstracts
{
    public abstract class GameCreator
    {
        public abstract IGame CreateGame();

        public string Initialize()
        {
            var game = CreateGame();

            var result = game.Play();

            return result;
        }
    }
}
