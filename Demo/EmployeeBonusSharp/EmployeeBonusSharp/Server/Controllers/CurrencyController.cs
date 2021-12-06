using EmployeeBonusSharp.Server.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmployeeBonusSharp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        private readonly ILogger<CurrencyController> _logger;

        public CurrencyController(ILogger<CurrencyController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetName")]
        public string GetName(int currencyISOCode)
        {
            return CurrencyDAO.GetName(currencyISOCode);
        }
    }
}
