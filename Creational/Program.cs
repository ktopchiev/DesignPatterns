using Creational.Builder;
using Creational.Builder.ConcreteBuilders;
using Creational.Builder.Contracts;
using Creational.Builder.Models;
using Creational.FactoryMethod;
using Creational.Singleton;

namespace Creational
{
    public class Program
    {
        static void Main(string[] args)
        {
            /** Factory method **/

            //new GameConsole().Start();

            /** Singleton **/
            /*The second variable should store the same instance as the first variable*/

            //var singleton1 = Singleton.Singleton.Get();
            //var singleton2 = Singleton.Singleton.Get();

            //if (singleton1 == singleton2)
            //{
            //    Console.WriteLine("It's working properly!");
            //}
            //else
            //{
            //    Console.WriteLine("Singleton is not working!");
            //}

            /** Builder **/

            SecurityAndroidBuilder secuirityAndroidBuilder = new SecurityAndroidBuilder();
            ExplorationAndroidBuilder explorationAndroidBuilder = new ExplorationAndroidBuilder();

            AndroidDirector androidDirector = new AndroidDirector(secuirityAndroidBuilder);
            AndroidDirector androidDirector1 = new AndroidDirector(explorationAndroidBuilder);

            AndroidRobot securityRobot = androidDirector.Builder.GetAndroidRobot();
            AndroidRobot explorationRobot = androidDirector1.Builder.GetAndroidRobot();

            Console.WriteLine("Security android: \n");
            securityRobot.ListParts();
            Console.WriteLine("Exploration android: \n");
            explorationRobot.ListParts();
        }
    }
}
