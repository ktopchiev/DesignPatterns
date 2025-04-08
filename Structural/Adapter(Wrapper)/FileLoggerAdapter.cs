namespace Structural.Adapter
{
    public class FileLoggerAdapter : ILogger
    {
        private readonly FileLogger _fileLogger;

        public FileLoggerAdapter(FileLogger fileLogger)
        {
            _fileLogger = fileLogger;
        }

        public void Log(string message)
        {
            _fileLogger.WriteToFile(message);
        }
    }
}
