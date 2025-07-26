using Bank.Entities.Exceptions;

namespace Bank.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double initialDeposit, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Deposit(initialDeposit);
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new DomainException("Invalid deposit amount");
            }

            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Insufficient balance");
            }

            Balance -= amount;
        }
    }
}
