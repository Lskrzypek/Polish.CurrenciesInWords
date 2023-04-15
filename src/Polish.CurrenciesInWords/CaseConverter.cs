namespace Polish.CurrenciesInWords
{
    internal static class CaseConverter
    {
        public static NumbersInWords.Case ToNumericCase(this CurrenciesInWords.Case @case)
        {
            return (NumbersInWords.Case) @case;
        }
    }
}
