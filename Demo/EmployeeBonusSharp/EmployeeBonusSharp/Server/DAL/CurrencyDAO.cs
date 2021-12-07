namespace EmployeeBonusSharp.Server.DAL;

public class CurrencyDAO
{
    public static string GetName(int currencyISOCode)
    {
        // Mock data.
        // todo Read data from a database.
        return (currencyISOCode == 840) ? "USD" : "EUR";
    }
}
