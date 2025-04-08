namespace Structural.Adapter
{
    public class FileLogger
    {
        public void WriteToFile(string message)
        {
            Console.WriteLine("Write some message to a file. " + message);
        }
    }
}
