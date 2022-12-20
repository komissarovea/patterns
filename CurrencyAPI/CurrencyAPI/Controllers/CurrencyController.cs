﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private ICurrencyService _currencyService;

        public CurrencyController(ICurrencyService currencyService) { 
            _currencyService = currencyService;
        }

        [HttpGet("/api/getCurrencyRate")]
        public IActionResult GetCurrencyRate(bool reverse)
        {
            double rateVal;
            try
            {
                 rateVal = _currencyService.GetCurrencyRate();
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
