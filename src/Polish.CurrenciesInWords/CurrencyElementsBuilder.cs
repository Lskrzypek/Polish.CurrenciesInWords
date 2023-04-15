using Polish.NumbersInWords;
using System;

namespace Polish.CurrenciesInWords
{
    /// <summary>
    /// Builder to provide currencies in words. Use fluent methods to setup words declension.
    /// </summary>
    public class CurrencyElementsBuilder
    {
        private decimal _amount;
        private Case _case = NumbersInWords.Case.Nominative;
        private ICurrency _currency;

        private ICurrencyElements _currencyElements = null;

        /// <summary>
        /// Currency elements with the currency in words and methods to manipulate it.
        /// </summary>
        public ICurrencyElements CurrencyElements
        {
            get
            {
                if (_currencyElements is null)
                    _currencyElements = CreateCurrencyElements();

                return _currencyElements;
            }
        }

        public CurrencyElementsBuilder(decimal amount, ICurrency currency)
        {
            _currency = currency;
            _amount = amount;
        }

        /// <summary>
        /// Sets a case of currency words. For example: Nominative (PL: mianownik), Genitive (PL: dopełniacz) etc.
        /// </summary>
        public CurrencyElementsBuilder Case(Case @case)
        {
            _case = @case;
            return this;
        }

        /// <summary>
        /// Returns a text created by the defined function. You can use it to create a phrase with specific declension.
        /// </summary>
        public string Write(Func<ICurrencyElements, string> writeFunc)
        {
            return writeFunc(CurrencyElements);
        }

        private ICurrencyElements CreateCurrencyElements()
        {
            return new CurrencyElements(_amount, _currency, _case);
        }

        /// <summary>
        /// Returns currency in words. For example 15.10 can be converted to: "piętnaście złotych i dziesięć groszy". To change the format use the Write method.
        /// </summary>
        public override string ToString()
        {
            return Write(DefaultCurrencyFormat.Get);
        }

        public static implicit operator string(CurrencyElementsBuilder builder) => builder.ToString();
    }
}
