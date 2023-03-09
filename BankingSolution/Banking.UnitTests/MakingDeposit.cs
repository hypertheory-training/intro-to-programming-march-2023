//using Banking.Domain;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Banking.UnitTests
//{
//    public class MakingDeposit
//    {
//        [Fact]
//        public void DepositsIncreasesTheBalance()
//        {
//            // given
//            var account = new BankAccount();
//            var openingBalance = account.GetBalance(); // Query (Func)
//            var amountToDeposit = 100M;
//            // when
//            account.Deposit(amountToDeposit); // Command (Action)         // then
//            Assert.Equal(openingBalance + amountToDeposit,
//     account.GetBalance());
//        }
//    }
//}



////////////////////////////   
///




using Banking.Domain;
using Xunit;

namespace Banking.UnitTests;

public class MakingDeposits
{
    [Theory]
    [InlineData(100)]
    [InlineData(1.25)]
    public void DepositsIncreasesTheBalance(decimal amountToDeposit)
    {
        // given
        var account = new BankAccount();
        var openingBalance = account.GetBalance(); // Query (Func)

        // when
        account.Deposit(amountToDeposit); // Command (Action)

        // then
        Assert.Equal(openingBalance + amountToDeposit,
            account.GetBalance());
    }
}