namespace Module2HW1
{
    public class Result
    {
        public Result()
        {
        }

        public Result(bool status, string message = "")
        {
            Status = status;
            Message = message;
        }

        public bool Status { get; init; }
        public string Message { get; init; }
    }
}
