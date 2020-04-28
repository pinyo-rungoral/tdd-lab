using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TddLab
{
    public class FuuService
    {
        public bool ValidateFirstSymbol(string input)
        {
            var allowSymbols = new List<string> { "[","(" };
            return allowSymbols.Any(c => input.StartsWith(c));
        }
    }
}
