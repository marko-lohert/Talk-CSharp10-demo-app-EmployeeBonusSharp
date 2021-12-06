namespace EmployeeBonusSharp.Shared
{
    public class Bonus
    {
        public int TotalPoints
        {
            get => LoyaltyPoints + CerificatePoints + PointsForHelpingColleagues + PointsPerformanceReview;
        }
        public Money TotalMoney { get; set; }
        
        /// <summary>
        /// Bonus points for years an employee spend in this company.
        /// </summary>
        public int LoyaltyPoints { get; set; }
        /// <summary>
        /// Bonus points for certificates that an employee has.
        /// </summary>
        public int CerificatePoints { get; set; }
        /// <summary>
        /// Bonus points that an employee gets for helping other employees.
        /// </summary>
        public int PointsForHelpingColleagues { get; set; }
        /// <summary>
        /// Bonus points earned in performance review.
        /// </summary>
        public int PointsPerformanceReview { get; set; }
    }
}
