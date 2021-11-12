using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public class Starter
    {
        public void Run()
        {
            Random rnd = new Random();

            var low_BoundRandom = 1;
            var high_BoundRandom = 5;
            Result res = null;
            Logger logger = Logger.Instance;
            for (var i = 0; i < 100; i++)
            {
                switch (rnd.Next(low_BoundRandom, high_BoundRandom))
                {
                    case 1:
                        res = new Action("Start method: MethodA").MethodA();
                        break;
                    case 2:
                        res = new Action("Skipped logic in method: MethodB").MethodB();
                        break;
                    case 3:
                        res = new Action("I broke a logic").MethodC();
                        break;
                    default:
                        res = new Result { Status = false, Message = "Unknown function" };
                        break;
                }

                if (!res.Status)
                {
                    logger = Logger.Instance;
                    logger.AppendMessage(LogType.Error, "Action failed by a reason: " + res.Message);
                }
            }

            File.WriteAllText("log.txt", logger.GetAllMessages());
        }
    }
}
