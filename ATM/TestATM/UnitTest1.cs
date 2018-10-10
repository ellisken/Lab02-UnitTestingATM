using System;
using Xunit;
using ATM;

namespace TestATM
{
    public class UnitTest1
    {
        //Test ValidateCheck()
        [Fact]
        public void ValidateCheckInvalidMenu()
        {
            Assert.Equal(-1, Program.ValidateChoice("6", true));
        }

        [Fact]
        public void ValidateCheckValidMenu()
        {
            Assert.Equal(3, Program.ValidateChoice("3", true));
        }

        [Fact]
        public void ValidateCheckValidAmount()
        {
            Assert.Equal(5000, Program.ValidateChoice("5000", false));
        }

        [Fact]
        public void ValidateCheckInvalidAmount()
        {
            Assert.Equal(-1, Program.ValidateChoice("-10", false));
        }


        //Test Withdraw()
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
