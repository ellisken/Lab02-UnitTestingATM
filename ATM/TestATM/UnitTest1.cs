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

        [Theory]
        [InlineData(99)]
        [InlineData(0)]
        [InlineData(.50)]
        public void TestWithdrawValid(double num)
        {
            Assert.Equal(0, Program.Withdraw(num));
        }

        [Theory]
        [InlineData(100)]
        [InlineData(1000)]
        public void TestWithdrawInvalid(double num)
        {
            Assert.Equal(-1, Program.Withdraw(num));
        }
    }

}
