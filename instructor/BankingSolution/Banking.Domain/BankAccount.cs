namespace Banking.Domain
{

    public enum BankAccountType { Standard, Gold, Platinum }

    public class BankAccount
    {
        public BankAccountType AccountType = BankAccountType.Standard;
        private decimal _balance = 5000;
        public void Deposit(decimal amountToDeposit)
        {
            // this is an if statement, and we do have a possibility for a bug here.
            var bonus = AccountType == BankAccountType.Gold ? amountToDeposit * .10M : 0;
            _balance += amountToDeposit + bonus;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw > _balance)
            {
                throw new OverdraftException();
            }
            else
            {
                _balance -= amountToWithdraw;
            }
        }
    }
}