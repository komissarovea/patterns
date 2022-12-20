namespace CurrencyAPI
{
    public interface ICurrencyService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<double> GetCurrencyRate();
    }
}
