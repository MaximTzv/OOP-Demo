
using KurtovoKonare.Customers;

namespace KurtovoKonare.Accounts
{
    public class Deposit : Account
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            :base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int period)
        {
            decimal rate;
            if (this.Balance > 0.0m && this.Balance < 1000m)
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
