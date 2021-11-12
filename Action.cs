namespace Module2HW1
{
    public class Action
    {
        private string _message;
        public Action(string message = "")
        {
            _message = message;
        }

        public Result MethodA()
        {
            Logger logger = Logger.Instance;
            logger.AppendMessage(LogType.Info, _message);
            return new Result(true, _message);
        }

        public Result MethodB()
        {
            Logger logger = Logger.Instance;
            logger.AppendMessage(LogType.Warning, _message);
            return new Result(true, _message);
        }

        public Result MethodC()
        {
            return new Result { Status = false };
        }
    }
}
