
namespace KurtovoKonare.Interfaces
{
    interface IAccount
    {
        decimal InterestRate { get; }
        decimal Balance { get; }
        decimal CalculateInterest(int period);
    }
}
