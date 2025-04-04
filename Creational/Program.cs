using Creational.Singleton;

namespace Creational
{
    public class Program
    {
        static void Main(string[] args)
        {
            /**Factory method**/

            //new GameConsole().Start();

            /**Singleton**/
            /*The second variable should store the same instance as the first variable*/

            var singleton1 = Singleton.Singleton.Get();
            var singleton2 = Singleton.Singleton.Get();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("It's working properly!");
            }
            else
            {
                Console.WriteLine("Singleton is not working!");
            }

        }
    }
}
