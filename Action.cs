namespace Module2HW1
{
    public static class Action
    {
        public static void MethodA(string mes, ref Result res)
        {
            // new StackTrace(false).GetFrame(0).GetMethod().Name
            Logger.GetInstance().FormMessageString(LogType.Info, mes);
            res.Status = true;
        }

        public static void MethodB(string mes, ref Result res)
        {
            Logger.GetInstance().FormMessageString(LogType.Warning, mes);
            res.Status = true;
        }

        public static void MethodC(string mes, ref Result res)
        {
            res.Message = mes;
            res.Status = false;
        }
    }
}
