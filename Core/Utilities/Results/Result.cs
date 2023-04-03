using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Get constructor da set edilebilir.
        //this(success) : ikinci constructor un da çalışmasını sağlar.
        //this: bu class demek.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        //Overloding : aşırı yükleme.
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
