using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //:base demek Result.cs ye erişmek demek.Çünkü SuccessResult Resulttan miras alıyor.Basedeki iki parametreli olan constructor u çalıştır
        public SuccessResult(string message):base(true,message)
        {

        }
        public SuccessResult():base(true)
        {

        }
    }
}
