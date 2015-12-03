
using KurtovoKonare.Customers;

namespace KurtovoKonare.Accounts
{
    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int period)
        {
            decimal rate;
            if (period <= 3 && this.Customer.CustomerType == CustomerType.IndividualCustomer)
            {
                rate = 0;
            }
            else if (period <= 2 && this.Customer.CustomerType == CustomerType.CompanyCustomer)
            {
                rate = 0;
            }
            else
            {
                rate = base.CalculateInterest(period);
            }
            return rate;
        }
    }
}
