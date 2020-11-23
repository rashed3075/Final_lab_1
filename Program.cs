using System;

namespace Final_th1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new SavingAccount("1101", "Saving Account", 2000.00);
            a1.Withdraw(1700);
            Console.WriteLine("**********************************");
            a1.ShowInfo();
            Console.WriteLine("**********************************");
            a1.Withdraw(600);
            Console.WriteLine("**********************************");
            a1.ShowInfo();
            Console.WriteLine("**********************************");
            Account a2 = new FixedAccount("1101", "Fixed Account", 2000.00, 2017, 2019);
            a2.Withdraw(1000);
            Console.WriteLine("**********************************");
            a2.ShowInfo();
            Console.WriteLine("**********************************");
            Account a3 = new FixedAccount("1101", "Fixed Account", 2000.00, 2017, 2019);
            a3.Withdraw(1000);
            Console.WriteLine("**********************************");
            a3.ShowInfo();
            Console.WriteLine("**********************************");
            Account a4 = new SpecialAccount("1101", "Special Account", 2000.00);
            a4.Withdraw(1900);
            Console.WriteLine("**********************************");
            a4.ShowInfo();
            Console.WriteLine("**********************************");
            a4.Withdraw(600);
            Console.WriteLine("**********************************");
            a4.ShowInfo();
            Console.WriteLine("**********************************");
            Account a5 = new Overdraft("1101", "Overdraft", 2000.00,600.00);
            a5.Withdraw(700);
            Console.WriteLine("******************************");
                a5.ShowInfo();
            Console.WriteLine("******************************");
            a5.Withdraw(400);
            Console.WriteLine("******************************");
            a5.ShowInfo();
            Console.WriteLine("******************************");

        }
    }
}
