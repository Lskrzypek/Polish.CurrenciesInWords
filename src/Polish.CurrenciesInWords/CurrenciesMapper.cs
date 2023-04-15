using Polish.CurrenciesInWords.Currencies;

namespace Polish.CurrenciesInWords
{
    internal static class CurrenciesMapper
    {
        public static ICurrency Map(Currency currency)
        {
            switch (currency)
            {
                case Currency.PLN: return new PLN();
                case Currency.EUR: return new EUR();
                case Currency.USD: return new USD();
                case Currency.INR: return new INR();

                default: return null;
            }
        }
    }
}
