

using Banking.Domain;

namespace Banking.UnitTests
{
    public class MakingDeposits
    {
        [Theory]
        [InlineData(100)]
        [InlineData(1.25)]
        public void DepositIncreaesTheBalance(decimal amountToDeposit)
        {
            //given
            var account = new BankAccount();
            var openingBalance = account.GetBalance();


            //when
            account.Deposit(amountToDeposit);

            //then
            Assert.Equal(openingBalance + amountToDeposit,
                account.GetBalance());
        }
    }
}
