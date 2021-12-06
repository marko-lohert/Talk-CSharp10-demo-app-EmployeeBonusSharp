using EmployeeBonusSharp.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace EmployeeBonusSharp.Client.Pages
{
    public partial class Index
    {
        public List<Employee> Employees { get; set; }
        public CompanyInfo Company { get; set; }
        public string BonusCurrencyName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await Http.GetFromJsonAsync<List<Employee>>("Employee/GetAllEmployees");
            Company = await Http.GetFromJsonAsync<CompanyInfo>("Company/GetInfo");
            BonusCurrencyName = await Http.GetStringAsync($"Currency/GetName?currencyISOCode={Company.BonusCurrencyISOCode}");
        }

        public void RecalculateBonus()
        {
            Func<Employee, int> YearsOfEmployment = employee => DateTime.Now.Subtract(employee.DateOfEmployment).Days / 365;

            foreach (Employee employee in Employees)
            {
                employee.EmployeeBonus.LoyaltyPoints = YearsOfEmployment(employee) * Company.CompanyBonusScheme.LoyaltyPointsPerYear;

                if (employee is not Employee { Certificates: { Count: 0 } })
                    employee.EmployeeBonus.CerificatePoints = employee.Certificates.Count * Company.CompanyBonusScheme.PointsPerCerificate;

                if (employee is not Employee { AllPerformanceReviewByManager: { Count: 0 } })
                {
                    employee.EmployeeBonus.PointsPerformanceReview = employee switch
                    {
                        { LastPerformanceReviewByManager: { Mark: 4 } } => Company.CompanyBonusScheme.PointsPerformanceReviewMark4,
                        { LastPerformanceReviewByManager: { Mark: 5 } } => Company.CompanyBonusScheme.PointsPerformanceReviewMark5,
                        _ => 0
                    };
                }

                employee.EmployeeBonus.PointsForHelpingColleagues = Company.CompanyBonusScheme.PointsForHelping5Colleagues * (employee.TotalVotesForHelpingOtherColleagues / 5);

                employee.EmployeeBonus.TotalMoney = new()
                {
                    Amount = employee.EmployeeBonus.TotalPoints * Company.BonusPointToMoney,
                    CurrencyISOCode = Company.BonusCurrencyISOCode
                };
            }
        }
    }
}
