using Polish.NumbersInWords;

namespace Polish.CurrenciesInWords.Currencies
{
    internal class PLN : ICurrency
    {
        public string ISO => "PLN";
        public string Symbol => "zł";
        public Gender MainUnitGender => Gender.Masculine;
        public Gender FractionalUnitGender => Gender.Masculine;
        public IPhrase MainUnitWord => new PLN_mainUnitWord();
        public IPhrase FractionalUnitWord => new PLN_fractionalUnitWord();
    }

    internal class PLN_mainUnitWord : IPhrase
    {
        public string NominativeForm => "złoty";
        public string GenitiveForm => "złotego";
        public string DativeForm => "złotemu";
        public string AccusativeForm => "złotego";
        public string InstrumentalForm => "złotym";
        public string LocativeForm => "złotym";
        public string VocativeForm => "złoty";
        public string PluralNominativeForm => "złote";
        public string PluralGenitiveForm => "złotych";
        public string PluralDativeForm => "złotym";
        public string PluralAccusativeForm => "złote";
        public string PluralInstrumentalForm => "złotymi";
        public string PluralLocativeForm => "złotych";
        public string PluralVocativeForm => "złote";
    }

    internal class PLN_fractionalUnitWord : IPhrase
    {
        public string NominativeForm => "grosz";
        public string GenitiveForm => "grosza";
        public string DativeForm => "groszowi";
        public string AccusativeForm => "grosz";
        public string InstrumentalForm => "groszem";
        public string LocativeForm => "groszu";
        public string VocativeForm => "grosz";
        public string PluralNominativeForm => "grosze";
        public string PluralGenitiveForm => "groszy";
        public string PluralDativeForm => "groszom";
        public string PluralAccusativeForm => "grosze";
        public string PluralInstrumentalForm => "groszami";
        public string PluralLocativeForm => "groszach";
        public string PluralVocativeForm => "grosze";
    }
}
