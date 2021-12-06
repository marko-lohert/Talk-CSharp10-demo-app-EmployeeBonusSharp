namespace EmployeeBonusSharp.Shared
{
    public readonly struct Currency
    {
        public Currency(int currencyISOCode, string name)
        {
            CurrencyISOCode = currencyISOCode;
            Name = name;
        }

        public readonly int CurrencyISOCode;
        public readonly string Name;
    }
}
