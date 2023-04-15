using Polish.CurrenciesInWords;

namespace Polish.Currencies.Tests
{
    public class DativeSolverTests
    {
        [Theory]
        [InlineData(0, "zeru z這tym")]
        [InlineData(1, "jednemu z這temu")]
        [InlineData(2, "dw鏔 z這tym")]
        [InlineData(3, "trzem z這tym")]
        [InlineData(4, "czterem z這tym")]
        [InlineData(5, "pi璚iu z這tym")]
        [InlineData(10, "dziesi璚iu z這tym")]
        [InlineData(11, "jedenastu z這tym")]
        [InlineData(12, "dwunastu z這tym")]
        [InlineData(13, "trzynastu z這tym")]
        [InlineData(21, "dwudziestu jeden z這tym")]
        [InlineData(22, "dwudziestu dw鏔 z這tym")]
        [InlineData(23, "dwudziestu trzem z這tym")]
        [InlineData(34, "trzydziestu czterem z這tym")]
        [InlineData(102, "stu dw鏔 z這tym")]
        [InlineData(105, "stu pi璚iu z這tym")]
        [InlineData(112, "stu dwunastu z這tym")]
        [InlineData(1000, "jednemu tysi鉍owi z這tych")]
        [InlineData(10000, "dziesi璚iu tysi鉍om z這tych")]
        [InlineData(10001, "dziesi璚iu tysi鉍om jeden z這tych")]
        [InlineData(1111, "jednemu tysi鉍owi stu jedenastu z這tym")]
        [InlineData(1_000_022, "jednemu milionowi dwudziestu dw鏔 z這tym")]
        [InlineData(0.23, "zeru z這tym i dwudziestu trzem groszom")]
        [InlineData(0.01, "zeru z這tym i jednemu groszowi")]
        [InlineData(0.02, "zeru z這tym i dw鏔 groszom")]
        [InlineData(0.03, "zeru z這tym i trzem groszom")]
        [InlineData(0.04, "zeru z這tym i czterem groszom")]
        [InlineData(0.05, "zeru z這tym i pi璚iu groszom")]
        [InlineData(112.32, "stu dwunastu z這tym i trzydziestu dw鏔 groszom")]
        public void Solve_PLN(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.PLN).Case(Case.Dative);
            Assert.Equal(expectedWords, resultWords);
        }

        [Theory]
        [InlineData(0, "zeru euro")]
        [InlineData(1, "jednemu euro")]
        [InlineData(2, "dw鏔 euro")]
        [InlineData(10, "dziesi璚iu euro")]
        [InlineData(1000, "jednemu tysi鉍owi euro")]
        [InlineData(0.01, "zeru euro i jednemu centowi")]
        [InlineData(0.02, "zeru euro i dw鏔 centom")]
        [InlineData(112.32, "stu dwunastu euro i trzydziestu dw鏔 centom")]
        public void Solve_EUR(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.EUR).Case(Case.Dative);
            Assert.Equal(expectedWords, resultWords);
        }


        [Theory]
        [InlineData(0, "zeru dolarom")]
        [InlineData(1, "jednemu dolarowi")]
        [InlineData(2, "dw鏔 dolarom")]
        [InlineData(10, "dziesi璚iu dolarom")]
        [InlineData(1000, "jednemu tysi鉍owi dolar闚")]
        [InlineData(0.01, "zeru dolarom i jednemu centowi")]
        [InlineData(0.02, "zeru dolarom i dw鏔 centom")]
        [InlineData(112.32, "stu dwunastu dolarom i trzydziestu dw鏔 centom")]
        public void Solve_USD(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.USD).Case(Case.Dative);
            Assert.Equal(expectedWords, resultWords);
        }
    }
}