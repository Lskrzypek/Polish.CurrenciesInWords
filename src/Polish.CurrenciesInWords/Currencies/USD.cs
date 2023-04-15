using Polish.NumbersInWords;

namespace Polish.CurrenciesInWords.Currencies
{
    internal class USD : ICurrency
    {
        public string ISO => "USD";
        public string Symbol => "$";
        public Gender MainUnitGender => Gender.Masculine;
        public Gender FractionalUnitGender => Gender.Masculine;
        public IPhrase MainUnitWord => new USD_mainUnitWord();
        public IPhrase FractionalUnitWord => new USD_fractionalUnitWord();
    }

    internal class USD_mainUnitWord : IPhrase
    {
        public string NominativeForm => "dolar";
        public string GenitiveForm => "dolara";
        public string DativeForm => "dolarowi";
        public string AccusativeForm => "dolara";
        public string InstrumentalForm => "dolarem";
        public string LocativeForm => "dolarze";
        public string VocativeForm => "dolarze";
        public string PluralNominativeForm => "dolary";
        public string PluralGenitiveForm => "dolarów";
        public string PluralDativeForm => "dolarom";
        public string PluralAccusativeForm => "dolary";
        public string PluralInstrumentalForm => "dolarami";
        public string PluralLocativeForm => "dolarach";
        public string PluralVocativeForm => "dolary";
    }

    internal class USD_fractionalUnitWord : IPhrase
    {
        public string NominativeForm => "cent";
        public string GenitiveForm => "centa";
        public string DativeForm => "centowi";
        public string AccusativeForm => "cent";
        public string InstrumentalForm => "centem";
        public string LocativeForm => "cencie";
        public string VocativeForm => "cent";
        public string PluralNominativeForm => "centy";
        public string PluralGenitiveForm => "centów";
        public string PluralDativeForm => "centom";
        public string PluralAccusativeForm => "centy";
        public string PluralInstrumentalForm => "centami";
        public string PluralLocativeForm => "centach";
        public string PluralVocativeForm => "centy";
    }
}
