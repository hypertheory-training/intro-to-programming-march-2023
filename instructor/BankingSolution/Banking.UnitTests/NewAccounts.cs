
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
