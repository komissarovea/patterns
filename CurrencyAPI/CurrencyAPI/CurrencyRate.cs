using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyAPI
{
    public class CurrencyRate
    {
        public double Value { get; set; }

        public bool  IsReversed { get; set; }


    }
}
