using System;
using System.Collections.Generic;
using System.Text;

namespace Final_th1
{
    class SpecialAccount : Account
    {
        public SpecialAccount() { }
        public SpecialAccount(string accNo, string accName, double balance) : base(accNo, accName, balance)
        {

        }
        public override void Withdraw(double amount)
        {
            if ((balance-amount)>=balance*0.2)
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
