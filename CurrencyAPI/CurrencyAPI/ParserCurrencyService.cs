using HtmlAgilityPack;
using System.Globalization;

namespace CurrencyAPI
{
    public class ParserCurrencyService : ICurrencyService
    {
        public async Task<double> GetCurrencyRate()
        {
            double rate = 0;
            var url = "http://www.finmarket.ru/currency/rates/?id=10089";

            var web = new HtmlWeb();
            var doc = await web.LoadFromWebAsync(url);

            var buttonNode = doc.GetElementbyId("ft_52148");

            var valueNode = buttonNode?.Descendants().Where(x => x.HasClass("value")).FirstOrDefault();

            if (valueNode != null)
            {
                string stringValue = valueNode.InnerText;
                rate = double.Parse(stringValue, new CultureInfo("ru")); // CultureInfo.InvariantCulture);
            }
            //var t = new { x = 1 };
            return rate;
        }
    }
}
