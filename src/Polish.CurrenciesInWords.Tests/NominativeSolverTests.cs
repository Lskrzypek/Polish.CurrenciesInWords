using Polish.CurrenciesInWords;

namespace Polish.Currencies.Tests
{
    public class NominativeSolverTests
    {
        [Theory]
        [InlineData(0, "zero z�otych")]
        [InlineData(1, "jeden z�oty")]
        [InlineData(2, "dwa z�ote")]
        [InlineData(3, "trzy z�ote")]
        [InlineData(4, "cztery z�ote")]
        [InlineData(5, "pi�� z�otych")]
        [InlineData(10, "dziesi�� z�otych")]
        [InlineData(11, "jedena�cie z�otych")]
        [InlineData(12, "dwana�cie z�otych")]
        [InlineData(13, "trzyna�cie z�otych")]
        [InlineData(21, "dwadzie�cia jeden z�otych")]
        [InlineData(22, "dwadzie�cia dwa z�ote")]
        [InlineData(23, "dwadzie�cia trzy z�ote")]
        [InlineData(34, "trzydzie�ci cztery z�ote")]
        [InlineData(102, "sto dwa z�ote")]
        [InlineData(105, "sto pi�� z�otych")]
        [InlineData(112, "sto dwana�cie z�otych")]
        [InlineData(1000, "jeden tysi�c z�otych")]
        [InlineData(10000, "dziesi�� tysi�cy z�otych")]
        [InlineData(1111, "jeden tysi�c sto jedena�cie z�otych")]
        [InlineData(1_000_022, "jeden milion dwadzie�cia dwa z�ote")]
        [InlineData(0.23, "zero z�otych i dwadzie�cia trzy grosze")]
        [InlineData(0.01, "zero z�otych i jeden grosz")]
        [InlineData(0.02, "zero z�otych i dwa grosze")]
        [InlineData(0.03, "zero z�otych i trzy grosze")]
        [InlineData(0.04, "zero z�otych i cztery grosze")]
        [InlineData(0.05, "zero z�otych i pi�� groszy")]
        [InlineData(112.32, "sto dwana�cie z�otych i trzydzie�ci dwa grosze")]
        [InlineData(1234566.85, "jeden milion dwie�cie trzydzie�ci cztery tysi�ce pi��set sze��dziesi�t sze�� z�otych i osiemdziesi�t pi�� groszy")]
        public void Solve_PLN(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.PLN);
            Assert.Equal(expectedWords, resultWords);
        }

        [Theory]
        [InlineData(0, "zero euro")]
        [InlineData(1, "jedno euro")]
        [InlineData(2, "dwa euro")]
        [InlineData(3, "trzy euro")]
        [InlineData(4, "cztery euro")]
        [InlineData(5, "pi�� euro")]
        [InlineData(10, "dziesi�� euro")]
        [InlineData(11, "jedena�cie euro")]
        [InlineData(12, "dwana�cie euro")]
        [InlineData(13, "trzyna�cie euro")]
        [InlineData(21, "dwadzie�cia jeden euro")]
        [InlineData(22, "dwadzie�cia dwa euro")]
        [InlineData(23, "dwadzie�cia trzy euro")]
        [InlineData(34, "trzydzie�ci cztery euro")]
        [InlineData(102, "sto dwa euro")]
        [InlineData(105, "sto pi�� euro")]
        [InlineData(112, "sto dwana�cie euro")]
        [InlineData(1000, "jeden tysi�c euro")]
        [InlineData(10000, "dziesi�� tysi�cy euro")]
        [InlineData(1111, "jeden tysi�c sto jedena�cie euro")]
        [InlineData(1_000_022, "jeden milion dwadzie�cia dwa euro")]
        [InlineData(0.23, "zero euro i dwadzie�cia trzy centy")]
        [InlineData(0.01, "zero euro i jeden cent")]
        [InlineData(0.02, "zero euro i dwa centy")]
        [InlineData(0.03, "zero euro i trzy centy")]
        [InlineData(0.04, "zero euro i cztery centy")]
        [InlineData(0.05, "zero euro i pi�� cent�w")]
        [InlineData(112.32, "sto dwana�cie euro i trzydzie�ci dwa centy")]
        public void Solve_EUR(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.EUR);
            Assert.Equal(expectedWords, resultWords);
        }

        [Theory]
        [InlineData(0, "zero dolar�w")]
        [InlineData(1, "jeden dolar")]
        [InlineData(2, "dwa dolary")]
        [InlineData(3, "trzy dolary")]
        [InlineData(4, "cztery dolary")]
        [InlineData(5, "pi�� dolar�w")]
        [InlineData(10, "dziesi�� dolar�w")]
        [InlineData(11, "jedena�cie dolar�w")]
        [InlineData(12, "dwana�cie dolar�w")]
        [InlineData(13, "trzyna�cie dolar�w")]
        [InlineData(21, "dwadzie�cia jeden dolar�w")]
        [InlineData(22, "dwadzie�cia dwa dolary")]
        [InlineData(23, "dwadzie�cia trzy dolary")]
        [InlineData(34, "trzydzie�ci cztery dolary")]
        [InlineData(102, "sto dwa dolary")]
        [InlineData(105, "sto pi�� dolar�w")]
        [InlineData(112, "sto dwana�cie dolar�w")]
        [InlineData(1000, "jeden tysi�c dolar�w")]
        [InlineData(10000, "dziesi�� tysi�cy dolar�w")]
        [InlineData(1111, "jeden tysi�c sto jedena�cie dolar�w")]
        [InlineData(1_000_022, "jeden milion dwadzie�cia dwa dolary")]
        [InlineData(0.23, "zero dolar�w i dwadzie�cia trzy centy")]
        [InlineData(0.01, "zero dolar�w i jeden cent")]
        [InlineData(0.02, "zero dolar�w i dwa centy")]
        [InlineData(0.03, "zero dolar�w i trzy centy")]
        [InlineData(0.04, "zero dolar�w i cztery centy")]
        [InlineData(0.05, "zero dolar�w i pi�� cent�w")]
        [InlineData(112.32, "sto dwana�cie dolar�w i trzydzie�ci dwa centy")]
        public void Solve_USD(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.USD);
            Assert.Equal(expectedWords, resultWords);
        }


        [Theory]
        [InlineData(0, "zero rupii")]
        [InlineData(1, "jedna rupia")]
        [InlineData(2, "dwie rupie")]
        [InlineData(3, "trzy rupie")]
        [InlineData(4, "cztery rupie")]
        [InlineData(5, "pi�� rupii")]
        [InlineData(10, "dziesi�� rupii")]
        [InlineData(11, "jedena�cie rupii")]
        [InlineData(12, "dwana�cie rupii")]
        [InlineData(13, "trzyna�cie rupii")]
        [InlineData(21, "dwadzie�cia jeden rupii")]
        [InlineData(22, "dwadzie�cia dwie rupie")]
        [InlineData(23, "dwadzie�cia trzy rupie")]
        [InlineData(34, "trzydzie�ci cztery rupie")]
        [InlineData(102, "sto dwie rupie")]
        [InlineData(105, "sto pi�� rupii")]
        [InlineData(112, "sto dwana�cie rupii")]
        [InlineData(1000, "jeden tysi�c rupii")]
        [InlineData(10000, "dziesi�� tysi�cy rupii")]
        [InlineData(1111, "jeden tysi�c sto jedena�cie rupii")]
        [InlineData(1_000_022, "jeden milion dwadzie�cia dwie rupie")]
        [InlineData(0.23, "zero rupii i dwadzie�cia trzy pajsy")]
        [InlineData(0.01, "zero rupii i jedna pajsa")]
        [InlineData(0.02, "zero rupii i dwie pajsy")]
        [InlineData(0.03, "zero rupii i trzy pajsy")]
        [InlineData(0.04, "zero rupii i cztery pajsy")]
        [InlineData(0.05, "zero rupii i pi�� pajs")]
        [InlineData(112.32, "sto dwana�cie rupii i trzydzie�ci dwie pajsy")]
        public void Solve_INR(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.INR);
            Assert.Equal(expectedWords, resultWords);
        }

        [Theory]
        [InlineData(123.55, "sto dwadzie�cia trzy PLN / 55")]
        public void Solve_PLN_specified_function(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.PLN)
                .Write(x => $"{x.MainUnitAmountInWords} {x.CurrencyISO} / {x.FractionalUnitAmount}");

            Assert.Equal(expectedWords, resultWords);
        }

    }
}