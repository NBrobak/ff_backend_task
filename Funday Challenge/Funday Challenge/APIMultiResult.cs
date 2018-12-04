using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FundayChallenge.Models;

namespace FundayChallenge
{
	public class APIMultiResult : APIResult
	{
		public IEnumerable<Pokemon> Data { get; set; }

		public override object DataAsObject
		{
			get { return Data; }
		}

		public APIMultiResult(IEnumerable<Pokemon> data) : base()
		{
			Data = data;
		}

		public APIMultiResult(string errorMessage) : base(errorMessage)
		{
			Data = null;
		}
	}
}
