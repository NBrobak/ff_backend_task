using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundayChallenge
{
    public abstract class APIResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
		public abstract object DataAsObject { get; }

        public APIResult()
        {
            Success = true;
            ErrorMessage = "";
        }

        public APIResult(string errorMessage)
        {
            Success = false;
            ErrorMessage = errorMessage;
        }
    }
}
