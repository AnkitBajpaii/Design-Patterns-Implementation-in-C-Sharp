using System;
using System.IO;

namespace Creational.Factory
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        string path;
        public FileLogger(string path)
        {
            this.path = path;
        }
        public void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(message);
            }
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging to Console: " + message);
        }
    }

    public interface ILoggerFactory
    {
        ILogger GetLogger(string type);
    }

    public class LoggerFactory : ILoggerFactory
    {
        public ILogger GetLogger(string type)
        {
            ILogger logger = null;

            if (type == "file")
            {
                logger = new FileLogger(@"C:\Users\Public\TestFolder\Log.txt");
            }
            else if (type == "console")
            {
                logger = new ConsoleLogger();
            }
            return logger;
        }
    }
}
