namespace Module2HW1
{
    public static class Action
    {
        public static Result MethodA()
        {
            // +new StackTrace(false).GetFrame(0).GetMethod().Name
            Logger.GetInstance(LogType.Info, "Start method: MethodA");
            return new Result(true);
        }

        public static Result MethodB()
        {
            Logger.GetInstance(LogType.Warning, "Skipped logic in method: MethodB");
            return new Result(true);
        }

        public static Result MethodC()
        {
            string mes = "I broke a logic";

            // Logger log = Logger.GetInstance(LogType.Error, mes);
            return new Result(false, mes);
        }
    }
}
