using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private ICurrencyService _currencyService;

        public CurrencyController(ICurrencyService currencyService) { 
            _currencyService = currencyService;
        }

        [HttpGet("getCurrencyRate")]
        public async Task<IActionResult> GetCurrencyRate(bool reverse = false)
        {
            double rateVal;
            try
            {
                 rateVal = await _currencyService.GetCurrencyRate();
                if (reverse)
                {
                    rateVal = 1 / rateVal;
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = $"Get Currency Rate error: {ex.Message}" });
            }
            CurrencyRate rate = new CurrencyRate() { Value = rateVal, IsReversed = reverse };
            return Ok(rate);
        }
    }
}
