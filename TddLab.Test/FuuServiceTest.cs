using System;
using System.Runtime.InteropServices.ComTypes;
using Xunit;

namespace TddLab.Test
{
    public class FuuServiceTest
    {
        [Theory(DisplayName = "PASS-CASE: First symbol is [ or (")]
        [InlineData("[1,5]")]
        [InlineData("(1,5]")]
        [InlineData("[1,5)")]
        [InlineData("(1,5)")]
        public void ValidateFirstSymbolTest(string input)
        {
            var service = new FuuService();
            var expected = true;
            var actual = service.ValidateFirstSymbol(input);
            Assert.Equal(expected, actual);
        }
    }
}
