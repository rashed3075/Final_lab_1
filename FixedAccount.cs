using System;
using System.Collections.Generic;
using System.Text;

namespace Final_th1
{
    class FixedAccount : Account
    {
        private int tenureYear;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }
        private int createYear;

        public int CreateYear
        {
            get { return createYear; }
            set { createYear = value; }
        }

        public FixedAccount()
        {

        }
        public FixedAccount(string accNo, string accName, double balance, int createYear, int tenureYear) : base(accNo, accName, balance)
        {
            this.createYear = createYear;
            this.tenureYear = tenureYear;
        }
        override public void Withdraw(double amount)
        {
            string curentYear = DateTime.Now.Year.ToString();
            int cyear = Int32.Parse(curentYear);
            if (cyear>=tenureYear)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Your account is not matured enough");
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
            Console.WriteLine("Account Opening Year: " + createYear);
            Console.WriteLine("Account Tenure Year: " + tenureYear);
        }
    }
}
