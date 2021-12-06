using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeBonusSharp.Shared
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Certificate> Certificates { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public int TotalVotesForHelpingOtherColleagues { get; set; }
        public List<PerformanceReviewByManager> AllPerformanceReviewByManager { get; set; }
        public PerformanceReviewByManager LastPerformanceReviewByManager
        {
            get
            {
                if (AllPerformanceReviewByManager is null or { Count: 0})
                    return null;

                return (from x in AllPerformanceReviewByManager
                        orderby x.DateOfReview
                        select x)
                        .LastOrDefault();
            }
        }
        public Bonus EmployeeBonus { get; set; }
    }
}
