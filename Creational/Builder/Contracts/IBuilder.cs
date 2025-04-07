using Creational.Builder.Models;

namespace Creational.Builder.Contracts
{
    public interface IBuilder
    {
        void BuildHead();
        void BuildTorso();
        void BuildArms();
        void BuildLegs();
        void BuildProcessor();
        void BuildSensors();
        AndroidRobot GetAndroidRobot();
    }
}
