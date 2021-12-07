namespace EmployeeBonusSharp.Shared
{
    public record struct Money
    {
        public decimal Amount { get; set; }
        public int CurrencyISOCode { get; set; }
    }
}