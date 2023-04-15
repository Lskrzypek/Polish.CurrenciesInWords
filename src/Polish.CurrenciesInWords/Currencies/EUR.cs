using Polish.NumbersInWords;

namespace Polish.CurrenciesInWords.Currencies
{
    internal class EUR : ICurrency
    {
        public string ISO => "EUR";
        public string Symbol => "€";
        public Gender MainUnitGender => Gender.Neuter;
        public Gender FractionalUnitGender => Gender.Masculine;
        public IPhrase MainUnitWord => new EUR_mainUnitWord();
        public IPhrase FractionalUnitWord => new EUR_fractionalUnitWord();
    }

    internal class EUR_mainUnitWord : IPhrase
    {
        public string NominativeForm => "euro";
        public string GenitiveForm => "euro";
        public string DativeForm => "euro";
        public string AccusativeForm => "euro";
        public string InstrumentalForm => "euro";
        public string LocativeForm => "euro";
        public string VocativeForm => "euro";
        public string PluralNominativeForm => "euro";
        public string PluralGenitiveForm => "euro";
        public string PluralDativeForm => "euro";
        public string PluralAccusativeForm => "euro";
        public string PluralInstrumentalForm => "euro";
        public string PluralLocativeForm => "euro";
        public string PluralVocativeForm => "euro";
    }

    internal class EUR_fractionalUnitWord : IPhrase
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
