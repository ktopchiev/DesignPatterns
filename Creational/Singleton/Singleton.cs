namespace Creational.Singleton
{
    public sealed class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        public static Singleton Get()
        {
            _instance ??= new Singleton();

            return _instance;
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("Some business logic executed.");
        }
    }
}
