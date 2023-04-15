using Polish.CurrenciesInWords;

namespace Polish.Currencies.Tests
{
    public class DativeSolverTests
    {
        [Theory]
        [InlineData(0, "zeru z�otym")]
        [InlineData(1, "jednemu z�otemu")]
        [InlineData(2, "dw�m z�otym")]
        [InlineData(3, "trzem z�otym")]
        [InlineData(4, "czterem z�otym")]
        [InlineData(5, "pi�ciu z�otym")]
        [InlineData(10, "dziesi�ciu z�otym")]
        [InlineData(11, "jedenastu z�otym")]
        [InlineData(12, "dwunastu z�otym")]
        [InlineData(13, "trzynastu z�otym")]
        [InlineData(21, "dwudziestu jeden z�otym")]
        [InlineData(22, "dwudziestu dw�m z�otym")]
        [InlineData(23, "dwudziestu trzem z�otym")]
        [InlineData(34, "trzydziestu czterem z�otym")]
        [InlineData(102, "stu dw�m z�otym")]
        [InlineData(105, "stu pi�ciu z�otym")]
        [InlineData(112, "stu dwunastu z�otym")]
        [InlineData(1000, "jednemu tysi�cowi z�otych")]
        [InlineData(10000, "dziesi�ciu tysi�com z�otych")]
        [InlineData(10001, "dziesi�ciu tysi�com jeden z�otych")]
        [InlineData(1111, "jednemu tysi�cowi stu jedenastu z�otym")]
        [InlineData(1_000_022, "jednemu milionowi dwudziestu dw�m z�otym")]
        [InlineData(0.23, "zeru z�otym i dwudziestu trzem groszom")]
        [InlineData(0.01, "zeru z�otym i jednemu groszowi")]
        [InlineData(0.02, "zeru z�otym i dw�m groszom")]
        [InlineData(0.03, "zeru z�otym i trzem groszom")]
        [InlineData(0.04, "zeru z�otym i czterem groszom")]
        [InlineData(0.05, "zeru z�otym i pi�ciu groszom")]
        [InlineData(112.32, "stu dwunastu z�otym i trzydziestu dw�m groszom")]
        public void Solve_PLN(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.PLN).Case(Case.Dative);
            Assert.Equal(expectedWords, resultWords);
        }

        [Theory]
        [InlineData(0, "zeru euro")]
        [InlineData(1, "jednemu euro")]
        [InlineData(2, "dw�m euro")]
        [InlineData(10, "dziesi�ciu euro")]
        [InlineData(1000, "jednemu tysi�cowi euro")]
        [InlineData(0.01, "zeru euro i jednemu centowi")]
        [InlineData(0.02, "zeru euro i dw�m centom")]
        [InlineData(112.32, "stu dwunastu euro i trzydziestu dw�m centom")]
        public void Solve_EUR(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.EUR).Case(Case.Dative);
            Assert.Equal(expectedWords, resultWords);
        }


        [Theory]
        [InlineData(0, "zeru dolarom")]
        [InlineData(1, "jednemu dolarowi")]
        [InlineData(2, "dw�m dolarom")]
        [InlineData(10, "dziesi�ciu dolarom")]
        [InlineData(1000, "jednemu tysi�cowi dolar�w")]
        [InlineData(0.01, "zeru dolarom i jednemu centowi")]
        [InlineData(0.02, "zeru dolarom i dw�m centom")]
        [InlineData(112.32, "stu dwunastu dolarom i trzydziestu dw�m centom")]
        public void Solve_USD(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.USD).Case(Case.Dative);
            Assert.Equal(expectedWords, resultWords);
        }
    }
}