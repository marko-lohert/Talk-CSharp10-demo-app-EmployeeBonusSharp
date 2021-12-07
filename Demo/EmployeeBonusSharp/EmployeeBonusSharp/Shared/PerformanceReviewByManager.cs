namespace EmployeeBonusSharp.Shared;

public record PerformanceReviewByManager
{
    public DateTime DateOfReview { get; init; }
    public decimal Mark { get; init; }
    public string Comment { get; init; }
}
