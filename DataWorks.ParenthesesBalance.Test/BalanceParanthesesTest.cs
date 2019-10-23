using System;
using Xunit;
using DataWorks.ParenthesesBalance;
namespace DataWorks.ParenthesesBalance.Test
{
    public class BalanceParanthesesTest
    {
        [Fact]
        public void ValidBalanceCheck()
        {
            //Arrange
            BalanceParantheses balance = new BalanceParantheses();
            //Act
            string parantheses = "(1)(sad)";
            //Assert
            Assert.True(balance.CheckBalance(parantheses));
        }

        [Fact]
        public void InvalidBalanceCheck()
        {
            //Arrange
            BalanceParantheses balance = new BalanceParantheses();
            //Act
            string parantheses = "(1)((sad)";
            //Assert
            Assert.False(balance.CheckBalance(parantheses));
        }
    }
}
