﻿namespace Module2HW1
{
    public class Result
    {
        public Result(bool status, string message = "")
        {
            Status = status;
            Message = message;
        }

        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
