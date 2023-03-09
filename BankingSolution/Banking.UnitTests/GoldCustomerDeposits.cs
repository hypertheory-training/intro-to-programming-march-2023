using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class GoldCustomerDeposits
    {
        [Fact]
        public void GoldCustomersGetABonusOnDeposits()
        {
            //var account = new BankAccount();
            //account.AccountType = BankAccountType.Gold;
            //var amountToDeposit = 10M;
            //var opiningbalance = account.GetBalance();

            //account.Deposit(amountToDeposit);

            //Assert.Equal(amountToDeposit + 10M + opiningbalance, account.GetBalance());

            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100M; account.Deposit(amountToDeposit); 
            Assert.Equal(amountToDeposit + openingBalance + 10M, account.GetBalance());
        }
    }
}
