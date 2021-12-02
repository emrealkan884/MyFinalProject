using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //IResult tan success ve message geliyor.Ayriyetten Data var
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
