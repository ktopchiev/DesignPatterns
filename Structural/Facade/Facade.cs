namespace Structural.Facade
{
    public class Facade
    {
        private readonly ComplexSystem _complexSystem;

        public Facade()
        {
            _complexSystem = new ComplexSystem();
        }

        public void UseComplexSystem()
        {
            var a = _complexSystem.DoSomethingA();
            var b = _complexSystem.DoSomethingB();
            var c = _complexSystem.DoSomethingC();

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
