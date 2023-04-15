using Polish.NumbersInWords;

namespace Polish.CurrenciesInWords.Currencies
{
    internal class INR : ICurrency
    {
        public string ISO => "INR";
        public string Symbol => "₹";
        public Gender MainUnitGender => Gender.Feminine;
        public Gender FractionalUnitGender => Gender.Feminine;


        public IPhrase MainUnitWord => new INR_mainUnitWord();
        public IPhrase FractionalUnitWord => new INR_fractionalUnitWord();
    }

    internal class INR_mainUnitWord : IPhrase
    {
        public string NominativeForm => "rupia";
        public string GenitiveForm => "rupii";
        public string DativeForm => "rupii";
        public string AccusativeForm => "rupię";
        public string InstrumentalForm => "rupią";
        public string LocativeForm => "rupii";
        public string VocativeForm => "rupio";
        public string PluralNominativeForm => "rupie";
        public string PluralGenitiveForm => "rupii";
        public string PluralDativeForm => "rupiom";
        public string PluralAccusativeForm => "rupie";
        public string PluralInstrumentalForm => "rupiami";
        public string PluralLocativeForm => "rupiach";
        public string PluralVocativeForm => "rupie";
    }

    internal class INR_fractionalUnitWord : IPhrase
    {
        public string NominativeForm => "pajsa";
        public string GenitiveForm => "pajsy";
        public string DativeForm => "pajsie";
        public string AccusativeForm => "pajsę";
        public string InstrumentalForm => "pajsą";
        public string LocativeForm => "pajsie";
        public string VocativeForm => "pajsa";
        public string PluralNominativeForm => "pajsy";
        public string PluralGenitiveForm => "pajs";
        public string PluralDativeForm => "pajsami";
        public string PluralAccusativeForm => "pajsy";
        public string PluralInstrumentalForm => "pajsami";
        public string PluralLocativeForm => "pajsach";
        public string PluralVocativeForm => "pajsy";
    }
}
