using Polish.NumbersInWords;

namespace Polish.CurrenciesInWords
{
    /// <summary>
    /// Currency - all data needs to convert a number to words in Polish
    /// </summary>
    public interface ICurrency
    {
        /// <summary>
        /// Official three-letter alphabetic code that represent the currency. Example: PLN, USD, EUR
        /// </summary>
        string ISO { get; }

        /// <summary>
        /// Currency symbol. Example: $, €, zł
        /// </summary>
        string Symbol { get; }

        /// <summary>
        /// Gender of the main unit. The main unit in 15.25 is 15. 
        /// </summary>
        Gender MainUnitGender { get; }

        /// <summary>
        /// Gender of the fractional unit. The fractional unit in 15.25 is 25. 
        /// </summary>
        Gender FractionalUnitGender { get; }

        /// <summary>
        /// The main unit word in all cases. The main unit in 15.25 is 15. 
        /// </summary>
        IPhrase MainUnitWord { get; }

        /// <summary>
        /// The fractional unit word in all cases. The fractional unit in 15.25 is 25. 
        /// </summary>
        IPhrase FractionalUnitWord { get; }
    }
}
