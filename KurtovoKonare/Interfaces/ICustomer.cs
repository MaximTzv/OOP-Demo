
using KurtovoKonare.Customers;

namespace KurtovoKonare.Interfaces
{
    interface ICustomer
    {
        string Name { get; }
        CustomerType CustomerType { get; }
    }
}
