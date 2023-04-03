using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç.
    //IResult Return gibi.
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
