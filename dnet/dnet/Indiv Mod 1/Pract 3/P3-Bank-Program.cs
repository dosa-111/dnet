using System;

namespace delc
{
    class BankAccount
    {
        private double balance;

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if( value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("NEGATIVE AHHHHHH !!!!");
                }
            }
        }
        public int AccountNumber { get; set; }
    }

    class Program
    {
        static void Main(String[]args)
        {
            BankAccount b = new BankAccount();
            b.AccountNumber = 5000;
            b.Balance = 1010010101;
            Console.WriteLine("BankAccount = " + b.AccountNumber);
            Console.WriteLine("Balance =" + b.Balance);
            b.Balance = -1000;
            Console.ReadLine();
            
        }
    }
}