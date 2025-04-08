using Structural.Facade;

namespace _2.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** Facade **/

            Facade facade = new Facade();
            facade.UseComplexSystem();
        }
    }
}
