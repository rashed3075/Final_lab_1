using System;
using System.Collections.Generic;
using System.Text;

namespace Final_th1
{
    
    class Overdraft : Account
    {
        private double withdrawLimit;

        public double WithdrawLimit
        {
            get { return withdrawLimit; }
            set { withdrawLimit = value; }
        }

        public Overdraft() { }
        public Overdraft(string accNo, string accName, double balance,double withdrawLimit) : base(accNo, accName, balance)
        {
            this.withdrawLimit = withdrawLimit;
        }

        public override void Withdraw(double amount)
        {
            if(amount<withdrawLimit)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
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
