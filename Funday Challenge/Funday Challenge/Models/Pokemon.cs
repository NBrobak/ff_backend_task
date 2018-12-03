using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundayChallenge.Models
{
    public class Pokemon
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Evolution { get; set; }
        public List<string> Types { get; set; }
        public bool IsLegendary { get; set; }
    }
}
