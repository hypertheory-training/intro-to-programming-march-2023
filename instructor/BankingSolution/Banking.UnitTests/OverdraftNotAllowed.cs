
using Banking.Domain;

namespace Banking.UnitTests;

public class OverdraftNotAllowed
{


    [Fact]
    public void OverdraftDoesNotDecreaseBalance()
    {
        // Given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        try
        {
            account.Withdraw(account.GetBalance() + .01M);
        }
        catch (OverdraftException)
        {

            // Ignore this..
        }

        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void OverdraftThrowsException()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        Assert.Throws<OverdraftException>(() =>
        {
            account.Withdraw(account.GetBalance() + .01M);

        });
    }
}
