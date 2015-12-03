using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurtovoKonare.Accounts;
using KurtovoKonare.Customers;
using KurtovoKonare.Interfaces;

namespace KurtovoKonare
{
    class BankMain
    {
        static void Main()
        {
            List<IAccount> accounts = new List<IAccount>()
            {
                new Deposit(new Customer("Vladimir Putin", CustomerType.IndividualCustomer), 10000.00m, 7.0m),
                new Deposit(new Customer("CIA EOOD", CustomerType.CompanyCustomer), 6544.00m, 0.07m),
                new Loan(new Customer("Barack Obama", CustomerType.IndividualCustomer), 1499882m, 54),
                new Loan(new Customer("Petar Ivanov", CustomerType.IndividualCustomer), 882m, 12),
                new Mortgage(new Customer("Yukos Oil", CustomerType.CompanyCustomer), 20000, 23),
                new Mortgage(new Customer("Prince Abdullah", CustomerType.IndividualCustomer), 56000, 1.2m)
            };
            
            foreach (var account in accounts)
            {
                Console.WriteLine("7 month interest on a {0} \n\r(balance: {1:C2}, rate:{2:F3}%): {3:C2}\n\r",
                    account.GetType().Name, account.Balance, account.InterestRate, account.CalculateInterest(7));
            }
        }
    }
}
