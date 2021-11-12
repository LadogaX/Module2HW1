using System;
using System.IO;
using System.Text;

namespace Module2HW1
{
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();

        private static StringBuilder _message = new StringBuilder();
        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public string AppendMessage(LogType logType, string currentMessage)
        {
            var message = $"{DateTime.UtcNow}: {logType}: {currentMessage}";
            _message.AppendLine(message);
            Console.WriteLine(message);
            return message;
        }

        public string GetAllMessages()
        {
            return _message.ToString();
        }
    }
}