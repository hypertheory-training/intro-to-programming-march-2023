

using Banking.Domain;

namespace Banking.UnitTests
{
    [Theory]
    [InlineData(100M)]
    [InlineData(5000M)]
    public class MakingWithdrawls
    {
        public void MakingWithdrawlDecreasesBalance(decimal amountToWithdraw)
        {
            //given
            var account = new BankAccount();
            var openingBalance = account.GetBalance();

            //when
            account.Withdraw(amountToWithdraw);

            //then
            Assert.Equal(openingBalance + amountToWithdraw,
                account.GetBalance());
        }
    }
}
