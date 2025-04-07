using Creational.Builder.Contracts;
using Creational.Builder.Models;

namespace Creational.Builder.ConcreteBuilders
{
    public class ExplorationAndroidBuilder : IBuilder
    {
        private AndroidRobot _androidRobot = new AndroidRobot();

        public void BuildArms()
        {
            _androidRobot.Arms = "Telescopic arms with multi-tools";
        }

        public void BuildHead()
        {
            _androidRobot.Head = "360° panoramic camera system";
        }

        public void BuildLegs()
        {
            _androidRobot.Legs = "Adaptive legs for climbing";
        }

        public void BuildProcessor()
        {
            _androidRobot.Processor = "Adaptive AI Core with pathfinding";
        }

        public void BuildSensors()
        {
            _androidRobot.Sensors = "GPS, seismic, atmospheric, radiation";
        }

        public void BuildTorso()
        {
            _androidRobot.Torso = "Lightweight modular shell";
        }

        public AndroidRobot GetAndroidRobot() => _androidRobot;

    }
}
