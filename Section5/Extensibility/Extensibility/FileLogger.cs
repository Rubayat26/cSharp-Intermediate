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

        public void LogError(string message)     //LogError needs to be public, as it is initilized
                                                 //in the interface 
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)      //LogInfo needs to be public 
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)   //Log is not of ILogger interface 
                                                               //so can be private, should be private  
        {
            using (var streamWriter = new StreamWriter(_path, true))   // using is needed for streamWriter here   
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}


// for streamWrtier we need to import System.IO
// 

// The StreamWriter uses a Flie Resource. A file resource is not managed by CLR or Common Language Runtime.
// which means we need to dispose that resource once we finish using that. The easiest way to do that is
// wrap that whole block in a using statement
// Behind the scene there is an exception handling mechanism inisde this using implemeted by the compiler
// so if something goes wrong the complier will do the file handle by calling the Dispose method on 
//the StreamWriter 
// So the StreamWriter.Dispose method is implemented automatically inside this using method 