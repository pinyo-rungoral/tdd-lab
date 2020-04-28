using System;
using System.Runtime.InteropServices.ComTypes;
using Xunit;

namespace TddLab.Test
{
    public class FuuTest
    {
        [Theory(DisplayName = "PASS-CASE: First symbol is [ or (")]
        [InlineData("[")]
        [InlineData("(")]
        public void FirstSymbolPassTest(string input)
        {
            
        }

        [InlineData("A")]
        [InlineData("a")]
        [InlineData("0")]
        [Theory(DisplayName = "FAIL-CASE: First symbol is [ or (")]
        public void FirstSymbolFailTest(string input)
        {

        }
    }
}
