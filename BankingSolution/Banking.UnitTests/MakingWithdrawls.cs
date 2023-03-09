//using Banking.Domain;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Banking.UnitTests
//{
//    public class MakingWithdrawls
//    {
//        //[Theory]

//        public void MakingAWithdrawalDecreasesBalance()
//        {
//            var account = new BankAccount();
//            var openingBalance = account.GetBalance(); // Query (Func)
//            var amountToWithdraw = 1M;
//            // when
//            account.Withdraw(amountToWithdraw); // Command (Action)         // then
//            Assert.Equal(openingBalance - amountToWithdraw,
//     account.GetBalance());
//        }
//    }
//}



using Banking.Domain;

namespace Banking.UnitTests;

public class MakingWithdrawals
{
    [Theory]
    [InlineData(1)]
    [InlineData(1020.22)]
    [InlineData(5000)]
    public void MakingAWithdrawalDecreasesBalance(decimal amountToWithdraw)
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance(); // Query (Func)

        // when
        account.Withdraw(amountToWithdraw); // Command (Action)

        // then
        Assert.Equal(openingBalance - amountToWithdraw,
            account.GetBalance());
    }
}