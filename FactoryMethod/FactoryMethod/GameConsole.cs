using Creational.FactoryMethod.Abstracts;
using Creational.FactoryMethod.Creators;

namespace Creational.FactoryMethod
{
    public class GameConsole
    {
        public void Start()
        {
            Console.WriteLine("Console started a new game: ");
            GameConsoleProcess(new TetrisCreator());

            Console.WriteLine("Console started a new game: ");
            GameConsoleProcess(new TicTacToeCreator());

            Console.WriteLine("Console started a new game: ");
            GameConsoleProcess(new CadillacsAndDinosaursCreator());
        }

        public void GameConsoleProcess(GameCreator gameCreator)
        {
            Console.WriteLine("Wait to initialize the game...\n" + gameCreator.Initialize());
        }
    }
}
