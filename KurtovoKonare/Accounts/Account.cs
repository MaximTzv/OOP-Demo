using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KurtovoKonare.Customers;
using KurtovoKonare.Interfaces;

namespace KurtovoKonare
{
    public abstract class Account : IAccount
    {
        private decimal balance;
        private decimal interestRate;
        private Customer customer;

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0.0m)
                {
                    throw  new ArgumentOutOfRangeException("balance", "Balance cannot be negative!");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate { get; set; }
        public Customer Customer { get; set; }


        public virtual decimal CalculateInterest(int period)
        {
            var rate = this.Balance*(1 + this.InterestRate*period);
            return rate;
        }
    }
}
