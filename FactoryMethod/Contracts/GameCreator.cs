namespace FactoryMethod.Contracts
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
