namespace EmployeeBonusSharp.Shared
{
    public struct BonusScheme
    {
        public BonusScheme(int LoyaltyPointsPerYear, int PointsPerCerificate, int PointsForHelping5Colleagues, int PointsPerformanceReviewMark4, int PointsPerformanceReviewMark5)
        {
            this.LoyaltyPointsPerYear = LoyaltyPointsPerYear;
            this.PointsPerCerificate = PointsPerCerificate;
            this.PointsForHelping5Colleagues = PointsForHelping5Colleagues;
            this.PointsPerformanceReviewMark4 = PointsPerformanceReviewMark4;
            this.PointsPerformanceReviewMark5 = PointsPerformanceReviewMark5;
        }

        public int LoyaltyPointsPerYear { get; set; }
        public int PointsPerCerificate { get; set; }
        public int PointsForHelping5Colleagues { get; set; }
        public int PointsPerformanceReviewMark4 { get; set; }
        public int PointsPerformanceReviewMark5 { get; set; }
    }
}
