namespace Extensibility
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}


// here the Interface and the class are stroed is separate file  