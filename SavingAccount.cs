using System;
using System.Collections.Generic;
using System.Text;

namespace Final_th1
{
    class SavingAccount : Account
    {
        public SavingAccount() { }
        public SavingAccount(string accNo, string accName, double balance) : base(accNo, accName, balance)
        {

        }
        public override void Withdraw(double amount)
        {
            if (balance - amount >= 500)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance");
        }
        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            
        }


    }
}
