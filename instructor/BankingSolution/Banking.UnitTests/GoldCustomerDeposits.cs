
using Banking.Domain;

namespace Banking.UnitTests;

public class GoldCustomerDeposits
{
    [Fact]
    public void GoldCustomersGetABonusOnDeposits()
    {
        var account = new BankAccount();
        account.AccountType = BankAccountType.Gold;
        var amountToDeposit = 100M;
        var openingBalance = account.GetBalance();

        account.Deposit(amountToDeposit);


        Assert.Equal(amountToDeposit + 10M + openingBalance,
            account.GetBalance());
    }
}
