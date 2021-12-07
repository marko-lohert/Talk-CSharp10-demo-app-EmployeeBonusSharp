namespace EmployeeBonusSharp.Server.DAL
{
    public class CompanyDAO
    {
        public static CompanyInfo GetInfo()
        {
            // Mock data.
            // todo Read data from a database.
            return new()
            {
                CompanyBonusScheme = new BonusScheme(LoyaltyPointsPerYear: 1, PointsPerCerificate: 5, PointsForHelping5Colleagues: 30, PointsPerformanceReviewMark4: 7, PointsPerformanceReviewMark5: 10),
                BonusPointToMoney = 50,
                BonusCurrencyISOCode = 840
            };
        }
    }
}
