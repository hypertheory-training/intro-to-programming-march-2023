
using Banking.Domain;

namespace Banking.UnitTests;

public class GoldCustomerDeposits
{
    [Fact]
    public void GoldCustomersGetABonusOnDeposits()
    {
        var account = new GoldBankAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;

        account.Deposit(amountToDeposit);

        Assert.Equal(amountToDeposit + openingBalance + 10M , account.GetBalance());
    }
}
