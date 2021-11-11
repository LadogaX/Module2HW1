using System;
using System.IO;

namespace Module2HW1
{
    public class Logger
    {
        private static Logger instance;
        private static int maxLengthNameEnum = 0;
        protected Logger()
        {
            maxLengthNameEnum = GetMaxLenghtNameEnum(typeof(LogType));
        }

        public static string Message { get; private set; }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public static void MessegesToFile(string logFile)
        {
            File.WriteAllText(logFile, Message);
        }

        public string FormMessageString(LogType logType, string currentMessage)
        {
            string mes = "{" + DateTime.UtcNow.ToString() + "}: {" + logType.ToString().PadRight(maxLengthNameEnum) + "}: {" + currentMessage + "}" + (char)13 + (char)10;
            Message += mes;
            Console.WriteLine(mes);
            return mes;
        }

        public static void Close()
        {
            if (instance != null)
            {
                instance = null;
            }
        }

        private static int GetMaxLenghtNameEnum(Type eNum)
        {
            int max = 0;
            foreach (string s in Enum.GetNames(eNum))
            {
                if (s.Length > max)
                {
                    max = s.Length;
                }
            }

            return max;
        }
    }
}
