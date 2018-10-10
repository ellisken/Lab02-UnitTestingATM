using System;
using Xunit;
using ATM;

namespace TestATM
{
    public class UnitTest1
    {
        [Fact]
        public void ValidateCheckInvalidNum()
        {
            Assert.Equal(-1, Program.ValidateChoice("6"));
        }

        [Fact]
        public void ValidateCheckValid()
        {
            Assert.Equal(3, Program.ValidateChoice("3"));
        }
    }

}
