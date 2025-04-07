using Creational.Builder.Contracts;
using Creational.Builder.Models;

namespace Creational.Builder.ConcreteBuilders
{
    public class SecurityAndroidBuilder : IBuilder
    {
        private AndroidRobot _androidRobot = new AndroidRobot();

        public void BuildArms()
        {
            _androidRobot.Arms = "Grappling arms with taser";
        }

        public void BuildHead()
        {
            _androidRobot.Head = "Night vision + facial recognition";
        }

        public void BuildLegs()
        {
            _androidRobot.Legs = "Fast mobility treads";
        }

        public void BuildProcessor()
        {
            _androidRobot.Processor = "Secure AI Core with threat analysis";
        }

        public void BuildSensors()
        {
            _androidRobot.Sensors = "Motion, infrared, heat, audio";
        }

        public void BuildTorso()
        {
            _androidRobot.Torso = "Reinforced steel casing";
        }

        public AndroidRobot GetAndroidRobot() => _androidRobot;
    }
}
