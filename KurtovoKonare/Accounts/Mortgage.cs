
using KurtovoKonare.Customers;

namespace KurtovoKonare.Accounts
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int period)
        {
            decimal rate;

            if (period <= 12 && this.Customer.CustomerType == CustomerType.CompanyCustomer)
            {
                rate = (this.Balance*(1 + this.InterestRate*period))*(1/2m);
            }
            else if (period <= 6 && this.Customer.CustomerType == CustomerType.IndividualCustomer)
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
