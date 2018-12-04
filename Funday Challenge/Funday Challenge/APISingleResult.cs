using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FundayChallenge.Models;

namespace FundayChallenge
{
    public class APISingleResult : APIResult
    {
		public Pokemon Data { get; set; }

		public override object DataAsObject
		{
			get { return Data; }
		}

		public APISingleResult(Pokemon data): base()
		{
			Data = data;
		}

		public APISingleResult(string errorMessage) : base(errorMessage)
		{
			Data = null;
		}
	}
}
