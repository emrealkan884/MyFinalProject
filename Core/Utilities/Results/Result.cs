using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //get readonly'dir.Bu yüzden constructorlarda set edilebilirler.
        //this demek class ın kendisi demek 
        //12-15. satırdaki contructor 17-20. satırdaki contructor ı kapsar. :this(succes) demek 17-20 satırı çalıştır demek.
        public Result(bool success, string message):this(success)
        {
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
