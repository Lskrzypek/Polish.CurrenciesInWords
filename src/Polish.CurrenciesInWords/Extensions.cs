namespace Polish.CurrenciesInWords
{
    /// <summary>
    /// Extends number types like <see langword="float" />, <see langword="decimal" />, <see langword="int" /> etc. to get a currency in Polish words.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Returns the number like a currency in words in Polish. Default currency is PLN. For example: 10.50 is conveted to "dziesięć złotych i pięćdziesiąt groszy". Use fluent methods to set up currency declension.
        /// </summary>
        /// <param name="currency">Enum with available currencies</param>
        /// <returns>Returns fluent builder, where you can setup date declension.</returns>
        public static CurrencyElementsBuilder ToCurrencyPolishWords(this decimal amount, Currency currency = Currency.PLN)
        {
            return DoToCurrencyWords(amount, currency);
        }

        /// <summary>
        /// Returns the number like a currency in words in Polish in current currency. For example: 10.50 can be converted to "dziesięć dolarów i pięćdziesiąt centów". Use fluent methods to set up currency declension.
        /// </summary>
        /// <param name="currency">Current currency interface</param>
        /// <returns>Returns fluent builder, where you can setup date declension.</returns>
        public static CurrencyElementsBuilder ToCurrencyPolishWords(this decimal amount, ICurrency currency)
        {
            return DoToCurrencyWords(amount, currency);
        }

        /// <summary>
        /// Returns the number like a currency in words in Polish. Default currency is PLN. For example: 10.50 is conveted to "dziesięć złotych i pięćdziesiąt groszy". Use fluent methods to set up currency declension.
        /// </summary>
        /// <param name="currency">Enum with available currencies</param>
        /// <returns>Returns fluent builder, where you can setup date declension.</returns>
        public static CurrencyElementsBuilder ToCurrencyPolishWords(this float amount, Currency currency = Currency.PLN)
        {
            return DoToCurrencyWords((decimal)amount, currency);
        }

        /// <summary>
        /// Returns the number like a currency in words in Polish in current currency. For example: 10.50 can be converted to "dziesięć dolarów i pięćdziesiąt centów". Use fluent methods to set up currency declension.
        /// </summary>
        /// <param name="currency">Current currency interface</param>
        /// <returns>Returns fluent builder, where you can setup date declension.</returns>
        public static CurrencyElementsBuilder ToCurrencyPolishWords(this float amount, ICurrency currency)
        {
            return DoToCurrencyWords((decimal)amount, currency);
        }

        /// <summary>
        /// Returns the number like a currency in words in Polish. Default currency is PLN. For example: 10.50 is conveted to "dziesięć złotych i pięćdziesiąt groszy". Use fluent methods to set up currency declension.
        /// </summary>
        /// <param name="currency">Enum with available currencies</param>
        /// <returns>Returns fluent builder, where you can setup date declension.</returns>
        public static CurrencyElementsBuilder ToCurrencyPolishWords(this double amount, Currency currency = Currency.PLN)
        {
            return DoToCurrencyWords((decimal)amount, currency);
        }

        /// <summary>
        /// Returns the number like a currency in words in Polish in current currency. For example: 10.50 can be converted to "dziesięć dolarów i pięćdziesiąt centów". Use fluent methods to set up currency declension.
        /// </summary>
        /// <param name="currency">Current currency interface</param>
        /// <returns>Returns fluent builder, where you can setup date declension.</returns>
        public static CurrencyElementsBuilder ToCurrencyPolishWords(this double amount, ICurrency currency)
        {
            return DoToCurrencyWords((decimal)amount, currency);
        }

        /// <summary>
        /// Returns the number like a currency in words in Polish. Default currency is PLN. For example: 10.50 is conveted to "dziesięć złotych i pięćdziesiąt groszy". Use fluent methods to set up currency declension.
        /// </summary>
        /// <param name="currency">Enum with available currencies</param>
        /// <returns>Returns fluent builder, where you can setup date declension.</returns>
        public static CurrencyElementsBuilder ToCurrencyPolishWords(this int amount, Currency currency = Currency.PLN)
        {
            return DoToCurrencyWords(amount, currency);
        }

        /// <summary>
        /// Returns the number like a currency in words in Polish in current currency. For example: 10.50 can be converted to "dziesięć dolarów i pięćdziesiąt centów". Use fluent methods to set up currency declension.
        /// </summary>
        /// <param name="currency">Current currency interface</param>
        /// <returns>Returns fluent builder, where you can setup date declension.</returns>
        public static CurrencyElementsBuilder ToCurrencyPolishWords(this int amount, ICurrency currency)
        {
            return DoToCurrencyWords(amount, currency);
        }

        /// <summary>
        /// Returns the number like a currency in words in Polish. Default currency is PLN. For example: 10.50 is conveted to "dziesięć złotych i pięćdziesiąt groszy". Use fluent methods to set up currency declension.
        /// </summary>
        /// <param name="currency">Enum with available currencies</param>
        /// <returns>Returns fluent builder, where you can setup date declension.</returns>
        public static CurrencyElementsBuilder ToCurrencyPolishWords(this long amount, Currency currency = Currency.PLN)
        {
            return DoToCurrencyWords(amount, currency);
        }

        /// <summary>
        /// Returns the number like a currency in words in Polish in current currency. For example: 10.50 can be converted to "dziesięć dolarów i pięćdziesiąt centów". Use fluent methods to set up currency declension.
        /// </summary>
        /// <param name="currency">Current currency interface</param>
        /// <returns>Returns fluent builder, where you can setup date declension.</returns>
        public static CurrencyElementsBuilder ToCurrencyPolishWords(this long amount, ICurrency currency)
        {
            return DoToCurrencyWords(amount, currency);
        }

        /// <summary>
        /// Returns the number like a currency in words in Polish. Default currency is PLN. For example: 10.50 is conveted to "dziesięć złotych i pięćdziesiąt groszy". Use fluent methods to set up currency declension.
        /// </summary>
        /// <param name="currency">Enum with available currencies</param>
        /// <returns>Returns fluent builder, where you can setup date declension.</returns>
        public static CurrencyElementsBuilder ToCurrencyPolishWords(this short amount, Currency currency = Currency.PLN)
        {
            return DoToCurrencyWords(amount, currency);
        }

        /// <summary>
        /// Returns the number like a currency in words in Polish in current currency. For example: 10.50 can be converted to "dziesięć dolarów i pięćdziesiąt centów". Use fluent methods to set up currency declension.
        /// </summary>
        /// <param name="currency">Current currency interface</param>
        /// <returns>Returns fluent builder, where you can setup date declension.</returns>
        public static CurrencyElementsBuilder ToCurrencyPolishWords(this short amount, ICurrency currency)
        {
            return DoToCurrencyWords(amount, currency);
        }

        private static CurrencyElementsBuilder DoToCurrencyWords(decimal amount, Currency currency)
        {
            var currencyClass = CurrenciesMapper.Map(currency);
            return DoToCurrencyWords(amount, currencyClass);
        }

        private static CurrencyElementsBuilder DoToCurrencyWords(decimal amount, ICurrency currency)
        {
            return new CurrencyElementsBuilder(amount, currency);
        }
    }
}
