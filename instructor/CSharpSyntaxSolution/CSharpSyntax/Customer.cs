
namespace CSharpSyntax;

public class Customer
{
    private decimal _availableCredit = 5000;
    /// <summary>
    /// Use this method to get the current credit limit
    /// </summary>
    /// <returns>What the customer's credit limit is right now</returns>
    public decimal GetCurrentAvailableCredit()
    {
        return _availableCredit;
    }
    /// <summary>
    /// Use this to increase the credit limit
    /// </summary>
    /// <param name="amount">The amount to ADD to the current credit limit</param>
    /// <param name="effectiveData">When this should be applied5</param>
    public void IncreaseAvailableCredit(decimal amount, DateTimeOffset effectiveData)
    {
        _availableCredit += amount;
    }
}
