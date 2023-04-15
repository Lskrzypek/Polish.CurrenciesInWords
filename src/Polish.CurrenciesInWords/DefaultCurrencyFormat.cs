namespace Polish.CurrenciesInWords
{
    internal static class DefaultCurrencyFormat
    {
        public static string Get(ICurrencyElements elements)
        {
            if (elements.FractionalUnitAmount == 0)
                return string.Format(
                    "{0} {1}",
                    elements.MainUnitAmountInWords,
                    elements.MainUnitInWords);

            return string.Format(
                "{0} {1} i {2} {3}",
                elements.MainUnitAmountInWords,
                elements.MainUnitInWords,
                elements.FractionalUnitAmountInWords,
                elements.FractionalUnitInWords);
        }
    }
}
