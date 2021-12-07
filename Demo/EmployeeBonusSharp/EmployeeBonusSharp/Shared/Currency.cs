namespace EmployeeBonusSharp.Shared
{
    public readonly record struct Currency
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
