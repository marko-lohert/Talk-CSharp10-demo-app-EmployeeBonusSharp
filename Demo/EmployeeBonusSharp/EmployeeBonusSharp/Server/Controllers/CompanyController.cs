using EmployeeBonusSharp.Server.DAL;
using EmployeeBonusSharp.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmployeeBonusSharp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly ILogger<CompanyController> _logger;

        public CompanyController(ILogger<CompanyController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetInfo")]
        public CompanyInfo GetInfo()
        {
            return CompanyDAO.GetInfo();
        }
    }
}
