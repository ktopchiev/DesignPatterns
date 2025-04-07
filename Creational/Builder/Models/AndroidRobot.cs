using System.Reflection;
using System.Text;

namespace Creational.Builder.Models
{
    public class AndroidRobot
    {
        public AndroidRobot() { }

        public string Head { get; set; }
        public string Torso { get; set; }
        public string Arms { get; set; }
        public string Legs { get; set; }
        public string Processor { get; set; }
        public string Sensors { get; set; }

        public void ListParts()
        {
            StringBuilder builder2 = new StringBuilder();

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            var androidRobotType = types.FirstOrDefault(t => t.Name == "AndroidRobot");
            PropertyInfo[] properties = androidRobotType.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                builder2.AppendLine($"{property.Name}: {property.GetValue(this)}");
            }

            Console.WriteLine(builder2.ToString());
        }

    }
}
