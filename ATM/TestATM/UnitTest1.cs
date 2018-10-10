using System;
using Xunit;
using ATM;

namespace TestATM
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(-1, Program.ValidateChoice("6"));
        }
    }
}
