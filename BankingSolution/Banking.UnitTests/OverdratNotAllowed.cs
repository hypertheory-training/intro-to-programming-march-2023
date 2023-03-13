using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Domain;
namespace Banking.UnitTests
{
    public class OverdratNotAllowed
    {
        [Fact]
        //public void BadBehaviorOverdraftIsAllowed()
        //{
        //    var account = new BankAccount(); account.Withdraw(account.GetBalance() + .01M); Assert.Equal(-.01M, account.GetBalance());
        //}
        //[Fact]
        public void OverdraftDoesNotDecreaseBalance()
        {
            // Given
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            //account.Withdraw(account.GetBalance() + .01M); Assert.Equal(openingBalance, account.GetBalance());
        }

    }
}



//////////  
///

//using Banking.Domain;
//namespace Banking.UnitTests;

//public class OverdraftNotAllowed
//{


//    [Fact]
//    public void BadBehaviorOverdraftIsAllowed()
//    public void OverdraftDoesNotDecreaseBalance()
//    {
//        // Given
//        var account = new BankAccount();
//        var openingBalance = account.GetBalance();

//        account.Withdraw(account.GetBalance() + .01M);
//        try
//        {
//            account.Withdraw(account.GetBalance() + .01M);
//        }
//        catch (OverdraftException)
//        {

//            Assert.Equal(-.01M, account.GetBalance());
//            // Ignore this..
//        }

//        Assert.Equal(openingBalance, account.GetBalance());
//    }

//    [Fact]
//    public void OverdraftDoesNotDecreaseBalance()
//    public void OverdraftThrowsException()
//    {
//        // Given
//        var account = new BankAccount();
//        var openingBalance = account.GetBalance();

//        account.Withdraw(account.GetBalance() + .01M);
//        Assert.Throws<OverdraftException>(() =>
//        {
//            account.Withdraw(account.GetBalance() + .01M);

//            Assert.Equal(openingBalance, account.GetBalance());
//        });
//    }
//}



//using Banking.Domain;

//namespace Banking.UnitTests;

//public class OverdraftNotAllowed
//{
//    [Fact]
//    public void BadBehaviorOverdraftIsAllowed()
//    {
//        var account = new BankAccount();

//        account.Withdraw(account.GetBalance() + .01M);

//        Assert.Equal(-.01M, account.GetBalance());
//    }

//    [Fact]
//    public void OverdraftDoesNotDecreaseBalance()
//    {
//        // Given
//        var account = new BankAccount();
//        var openingBalance = account.GetBalance();

//        account.Withdraw(account.GetBalance() + .01M);

//        Assert.Equal(openingBalance, account.GetBalance());
//    }
//}