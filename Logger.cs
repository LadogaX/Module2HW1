using System;
using System.IO;

namespace Module2HW1
{
    public class Logger
    {
        private static Logger instance;

        protected Logger()
        {
        }

        public static string Message { get; private set; }
        public static LogType TypeLog { get; private set; }

        public static Logger GetInstance(LogType logType, string message)
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            TypeLog = logType;
            instance.FormMessageString(message);
            return instance;
        }

        public static void MessegesToFile(string logFile)
        {
            File.WriteAllText(logFile, Message);
        }

        private string FormMessageString(string currentMessage)
        {
            string mes = "{" + DateTime.Now.ToString() + "}: {" + TypeLog.ToString() + "}: {" + currentMessage + "}" + (char)13 + (char)10;
            Message += mes;
            Console.WriteLine(mes);
            return mes;
        }
    }
}
