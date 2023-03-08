namespace Banking.Domain
{
    public class BankAccount
    {
        private decimal _balance = 5000;
        public virtual void Deposit(decimal amountToDeposit)
        {
            // Write the code you wish you had
            // decimal bonusToAdd = _bonusCalculator.CalculateBonusFor(_balance, amountToDeposit);
            _balance += amountToDeposit;// + bonusToAdd;
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