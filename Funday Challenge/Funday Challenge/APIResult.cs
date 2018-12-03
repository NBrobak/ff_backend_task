using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundayChallenge
{
    public class APIResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public object Data { get; set; }

        public APIResult(object data)
        {
            Success = true;
            ErrorMessage = "";
            Data = data;
        }

        public APIResult(string errorMessage)
        {
            Success = false;
            ErrorMessage = errorMessage;
            Data = null;
        }
    }
}
