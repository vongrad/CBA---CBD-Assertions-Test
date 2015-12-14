using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace ConsoleApplication1
{
    class Account
    {
        private double balance;

        public Account(double balance) {
            this.balance = balance;
        }

        public void deposit(double amount) {
            Contract.Requires(amount > 0, "The amount has to be always positive.");
            balance += amount;
            Contract.Ensures(balance > 0, "The balance has to be always positivie.");
        }

        public void withdraw(double amount){
            Contract.Requires(amount > 0, "The withdrawal amount has to be positive.");
            Contract.Requires<MaximumAmountException>(amount < balance, "The widthdrawal amount cannot exceed the account balance.");
            Contract.Ensures(balance < 0, "The account balance cannot be negative");
            balance -= amount;
        }
    }
}
