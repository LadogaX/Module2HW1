using System;
using System.Collections.Generic;
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

            byte low_BoundRandom = 1;
            byte high_BoundRandom = 4;
            Result res = new Result(false);
            for (int i = 0; i < 100; i++)
            {
                switch (rnd.Next(low_BoundRandom, high_BoundRandom))
                {
                    case 1: Action.MethodA("Start method: MethodA", ref res); break;
                    case 2: Action.MethodB("Skipped logic in method: MethodB", ref res); break;
                    case 3: Action.MethodC("I broke a logic", ref res); break;
                }

                if (!res.Status)
                {
                    Logger.GetInstance().FormMessageString(LogType.Error, "Action failed by a reason: " + res.Message);
                }
            }

            Console.ReadLine();
            Logger.MessegesToFile("log.txt");
            Logger.Close();
        }
    }
}
