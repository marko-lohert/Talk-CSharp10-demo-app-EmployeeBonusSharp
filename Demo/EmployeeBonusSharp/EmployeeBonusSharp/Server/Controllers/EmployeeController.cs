namespace EmployeeBonusSharp.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("GetAllEmployees")]
    public IEnumerable<Employee> GetAllEmployees()
    {
        return EmployeeDAO.GetAllEmployees();
    }
}
