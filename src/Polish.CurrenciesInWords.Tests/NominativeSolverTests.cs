using Polish.CurrenciesInWords;

namespace Polish.Currencies.Tests
{
    public class NominativeSolverTests
    {
        [Theory]
        [InlineData(0, "zero z³otych")]
        [InlineData(1, "jeden z³oty")]
        [InlineData(2, "dwa z³ote")]
        [InlineData(3, "trzy z³ote")]
        [InlineData(4, "cztery z³ote")]
        [InlineData(5, "piêæ z³otych")]
        [InlineData(10, "dziesiêæ z³otych")]
        [InlineData(11, "jedenaœcie z³otych")]
        [InlineData(12, "dwanaœcie z³otych")]
        [InlineData(13, "trzynaœcie z³otych")]
        [InlineData(21, "dwadzieœcia jeden z³otych")]
        [InlineData(22, "dwadzieœcia dwa z³ote")]
        [InlineData(23, "dwadzieœcia trzy z³ote")]
        [InlineData(34, "trzydzieœci cztery z³ote")]
        [InlineData(102, "sto dwa z³ote")]
        [InlineData(105, "sto piêæ z³otych")]
        [InlineData(112, "sto dwanaœcie z³otych")]
        [InlineData(1000, "jeden tysi¹c z³otych")]
        [InlineData(10000, "dziesiêæ tysiêcy z³otych")]
        [InlineData(1111, "jeden tysi¹c sto jedenaœcie z³otych")]
        [InlineData(1_000_022, "jeden milion dwadzieœcia dwa z³ote")]
        [InlineData(0.23, "zero z³otych i dwadzieœcia trzy grosze")]
        [InlineData(0.01, "zero z³otych i jeden grosz")]
        [InlineData(0.02, "zero z³otych i dwa grosze")]
        [InlineData(0.03, "zero z³otych i trzy grosze")]
        [InlineData(0.04, "zero z³otych i cztery grosze")]
        [InlineData(0.05, "zero z³otych i piêæ groszy")]
        [InlineData(112.32, "sto dwanaœcie z³otych i trzydzieœci dwa grosze")]
        [InlineData(1234566.85, "jeden milion dwieœcie trzydzieœci cztery tysi¹ce piêæset szeœædziesi¹t szeœæ z³otych i osiemdziesi¹t piêæ groszy")]
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
        [InlineData(5, "piêæ euro")]
        [InlineData(10, "dziesiêæ euro")]
        [InlineData(11, "jedenaœcie euro")]
        [InlineData(12, "dwanaœcie euro")]
        [InlineData(13, "trzynaœcie euro")]
        [InlineData(21, "dwadzieœcia jeden euro")]
        [InlineData(22, "dwadzieœcia dwa euro")]
        [InlineData(23, "dwadzieœcia trzy euro")]
        [InlineData(34, "trzydzieœci cztery euro")]
        [InlineData(102, "sto dwa euro")]
        [InlineData(105, "sto piêæ euro")]
        [InlineData(112, "sto dwanaœcie euro")]
        [InlineData(1000, "jeden tysi¹c euro")]
        [InlineData(10000, "dziesiêæ tysiêcy euro")]
        [InlineData(1111, "jeden tysi¹c sto jedenaœcie euro")]
        [InlineData(1_000_022, "jeden milion dwadzieœcia dwa euro")]
        [InlineData(0.23, "zero euro i dwadzieœcia trzy centy")]
        [InlineData(0.01, "zero euro i jeden cent")]
        [InlineData(0.02, "zero euro i dwa centy")]
        [InlineData(0.03, "zero euro i trzy centy")]
        [InlineData(0.04, "zero euro i cztery centy")]
        [InlineData(0.05, "zero euro i piêæ centów")]
        [InlineData(112.32, "sto dwanaœcie euro i trzydzieœci dwa centy")]
        public void Solve_EUR(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.EUR);
            Assert.Equal(expectedWords, resultWords);
        }

        [Theory]
        [InlineData(0, "zero dolarów")]
        [InlineData(1, "jeden dolar")]
        [InlineData(2, "dwa dolary")]
        [InlineData(3, "trzy dolary")]
        [InlineData(4, "cztery dolary")]
        [InlineData(5, "piêæ dolarów")]
        [InlineData(10, "dziesiêæ dolarów")]
        [InlineData(11, "jedenaœcie dolarów")]
        [InlineData(12, "dwanaœcie dolarów")]
        [InlineData(13, "trzynaœcie dolarów")]
        [InlineData(21, "dwadzieœcia jeden dolarów")]
        [InlineData(22, "dwadzieœcia dwa dolary")]
        [InlineData(23, "dwadzieœcia trzy dolary")]
        [InlineData(34, "trzydzieœci cztery dolary")]
        [InlineData(102, "sto dwa dolary")]
        [InlineData(105, "sto piêæ dolarów")]
        [InlineData(112, "sto dwanaœcie dolarów")]
        [InlineData(1000, "jeden tysi¹c dolarów")]
        [InlineData(10000, "dziesiêæ tysiêcy dolarów")]
        [InlineData(1111, "jeden tysi¹c sto jedenaœcie dolarów")]
        [InlineData(1_000_022, "jeden milion dwadzieœcia dwa dolary")]
        [InlineData(0.23, "zero dolarów i dwadzieœcia trzy centy")]
        [InlineData(0.01, "zero dolarów i jeden cent")]
        [InlineData(0.02, "zero dolarów i dwa centy")]
        [InlineData(0.03, "zero dolarów i trzy centy")]
        [InlineData(0.04, "zero dolarów i cztery centy")]
        [InlineData(0.05, "zero dolarów i piêæ centów")]
        [InlineData(112.32, "sto dwanaœcie dolarów i trzydzieœci dwa centy")]
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
        [InlineData(5, "piêæ rupii")]
        [InlineData(10, "dziesiêæ rupii")]
        [InlineData(11, "jedenaœcie rupii")]
        [InlineData(12, "dwanaœcie rupii")]
        [InlineData(13, "trzynaœcie rupii")]
        [InlineData(21, "dwadzieœcia jeden rupii")]
        [InlineData(22, "dwadzieœcia dwie rupie")]
        [InlineData(23, "dwadzieœcia trzy rupie")]
        [InlineData(34, "trzydzieœci cztery rupie")]
        [InlineData(102, "sto dwie rupie")]
        [InlineData(105, "sto piêæ rupii")]
        [InlineData(112, "sto dwanaœcie rupii")]
        [InlineData(1000, "jeden tysi¹c rupii")]
        [InlineData(10000, "dziesiêæ tysiêcy rupii")]
        [InlineData(1111, "jeden tysi¹c sto jedenaœcie rupii")]
        [InlineData(1_000_022, "jeden milion dwadzieœcia dwie rupie")]
        [InlineData(0.23, "zero rupii i dwadzieœcia trzy pajsy")]
        [InlineData(0.01, "zero rupii i jedna pajsa")]
        [InlineData(0.02, "zero rupii i dwie pajsy")]
        [InlineData(0.03, "zero rupii i trzy pajsy")]
        [InlineData(0.04, "zero rupii i cztery pajsy")]
        [InlineData(0.05, "zero rupii i piêæ pajs")]
        [InlineData(112.32, "sto dwanaœcie rupii i trzydzieœci dwie pajsy")]
        public void Solve_INR(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.INR);
            Assert.Equal(expectedWords, resultWords);
        }

        [Theory]
        [InlineData(123.55, "sto dwadzieœcia trzy PLN / 55")]
        public void Solve_PLN_specified_function(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.PLN)
                .Write(x => $"{x.MainUnitAmountInWords} {x.CurrencyISO} / {x.FractionalUnitAmount}");

            Assert.Equal(expectedWords, resultWords);
        }

    }
}