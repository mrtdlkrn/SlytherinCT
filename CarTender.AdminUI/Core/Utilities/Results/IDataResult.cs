using System;
using System.Collections.Generic;
using System.Text;

namespace ContactProject.Core.Utilities.Results
{
    public interface IDataResult<T> : IResult where T:class
    {
        T Data { get; }
    }
}
