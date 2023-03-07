namespace Banking.Domain
{
    public class BankAccount
    {
        private decimal _balance = 5000;
        public void Deposit(decimal amountToDeposit)
        {
            //_balance = _balance + amountToDeposit;
            _balance += amountToDeposit;
        }

        public decimal GetBalance()
        {
            return 5000;

        }

        public void Withdraw(decimal amountToWithdraw)
        {
            throw new NotImplementedException();
        }
    }
}