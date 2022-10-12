using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Newtonsoft.Json;

namespace CT.AdminUI.ExceptionHandler
{
    public class ErrorDetails
    {
        public bool success { get; }

        public string message { get; }

        public ErrorDetails(bool IsSuccess, string ErrorMessage)
        {
            success = IsSuccess;
            message = ErrorMessage;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
