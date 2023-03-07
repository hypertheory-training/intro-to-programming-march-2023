using Banking.Domain;

namespace Banking.UnitTests
{
    public class NewAccount
    {
        [Fact]
        public void NewAccountHasCorrectOpeningBalanace()
        {
            //Write the code you wish you had
            //Given
            BankAccount account = new BankAccount();

            //When
            decimal balance = account.GetBalance();
            //then
            Assert.Equal(5000, balance);
        }
    }
}
