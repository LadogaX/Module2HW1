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
            Result res = default;
            for (int i = 0; i < 100; i++)
            {
                switch (rnd.Next(low_BoundRandom, high_BoundRandom))
                {
                    case 1: res = Action.MethodA(); break;
                    case 2: res = Action.MethodB(); break;
                    case 3: res = Action.MethodC(); break;
                }

                if (!res.Status)
                {
                    Logger.GetInstance(LogType.Error, "Action failed by a reason. " + res.Message);
                }
            }

            Logger.MessegesToFile("log.txt");
            Console.ReadLine();
        }
    }
}
