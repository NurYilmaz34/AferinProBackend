using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //get readonly'dir ve constructor'da set edilebilirlerlerlelrlelerlellee :))
        public Result(bool success, string message):this(success)
        {//this yani bu class'ın tek parametreli constructor'ına succes'i yolladım !
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
