//using Banking.Domain;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Banking.UnitTests
//{

//    public class NewAccounts

//    {
//        [Fact]
//        public void NewAccountHasCorrectOpeningBalance()

//        {

//            BankAccount account = new BankAccount();

//            decimal balance = account.GetBalance();

//            Assert.Equal(5000, balance);


//        }
//    }
//}



using Banking.Domain;

namespace Banking.UnitTests;

public class NewAccounts
{
    [Fact]
    public void NewAccountHasCorrectOpeningBalance()
    {
        // "Write the Code You Wish You Had" (WTCYWYH)
        // Given
        // Type identifier = initializer;
        var account = new BankAccount();
        // When
        decimal balance = account.GetBalance();
        // Then
        Assert.Equal(5000, balance);



    }
}
