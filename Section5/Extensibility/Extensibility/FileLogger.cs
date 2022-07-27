using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger        // as FileLogger is based on ILogger; LogError and LogInfo comes with ILogger
                                             // In FileLoggers constructor we have added string path
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))   // using is needed for streamWriter here   
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}