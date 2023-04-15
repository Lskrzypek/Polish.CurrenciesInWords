namespace Polish.CurrenciesInWords
{
    /// <summary>
    /// Currency elements with the currency in words and methods to manipulate it.
    /// </summary>
    public interface ICurrencyElements
    {
        /// <summary>
        /// Whole amount. For example 100.10.
        /// </summary>
        decimal Amount { get; }

        /// <summary>
        /// Main currency unit amount. For example 100.10$ return 100.
        /// </summary>
        long MainUnitAmount { get; }

        /// <summary>
        /// Main currency unit amount in Polish words. For example 100.10$ return "sto".
        /// </summary>
        string MainUnitAmountInWords { get; }

        /// <summary>
        /// Main currency unit in Polish words. For example 100.10$ return "dolarów".
        /// </summary>
        string MainUnitInWords { get; }

        /// <summary>
        /// Fractional currency unit amount. For example 100.10$ return 10.
        /// </summary>
        short FractionalUnitAmount { get; }

        /// <summary>
        /// Fractional currency unit amount in Polish words. For example 100.10$ return "dziesięć".
        /// </summary>
        string FractionalUnitAmountInWords { get; }

        /// <summary>
        /// Fractional currency unit in Polish words. For example 100.10$ return "centów".
        /// </summary>
        string FractionalUnitInWords { get; }

        /// <summary>
        /// Currency ISO code. For example 100.10$ return "USD".
        /// </summary>
        string CurrencyISO { get; }

        /// <summary>
        /// Currency symbol if exists. For example 100.10$ return "$". If not exists symbol in currency then return "".
        /// </summary>
        string CurrencySymbol { get; }
    }
}
