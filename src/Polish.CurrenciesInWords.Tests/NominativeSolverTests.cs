using Polish.CurrenciesInWords;

namespace Polish.Currencies.Tests
{
    public class NominativeSolverTests
    {
        [Theory]
        [InlineData(0, "zero z這tych")]
        [InlineData(1, "jeden z這ty")]
        [InlineData(2, "dwa z這te")]
        [InlineData(3, "trzy z這te")]
        [InlineData(4, "cztery z這te")]
        [InlineData(5, "pi耩 z這tych")]
        [InlineData(10, "dziesi耩 z這tych")]
        [InlineData(11, "jedena�cie z這tych")]
        [InlineData(12, "dwana�cie z這tych")]
        [InlineData(13, "trzyna�cie z這tych")]
        [InlineData(21, "dwadzie�cia jeden z這tych")]
        [InlineData(22, "dwadzie�cia dwa z這te")]
        [InlineData(23, "dwadzie�cia trzy z這te")]
        [InlineData(34, "trzydzie�ci cztery z這te")]
        [InlineData(102, "sto dwa z這te")]
        [InlineData(105, "sto pi耩 z這tych")]
        [InlineData(112, "sto dwana�cie z這tych")]
        [InlineData(1000, "jeden tysi鉍 z這tych")]
        [InlineData(10000, "dziesi耩 tysi璚y z這tych")]
        [InlineData(1111, "jeden tysi鉍 sto jedena�cie z這tych")]
        [InlineData(1_000_022, "jeden milion dwadzie�cia dwa z這te")]
        [InlineData(0.23, "zero z這tych i dwadzie�cia trzy grosze")]
        [InlineData(0.01, "zero z這tych i jeden grosz")]
        [InlineData(0.02, "zero z這tych i dwa grosze")]
        [InlineData(0.03, "zero z這tych i trzy grosze")]
        [InlineData(0.04, "zero z這tych i cztery grosze")]
        [InlineData(0.05, "zero z這tych i pi耩 groszy")]
        [InlineData(112.32, "sto dwana�cie z這tych i trzydzie�ci dwa grosze")]
        [InlineData(1234566.85, "jeden milion dwie�cie trzydzie�ci cztery tysi鉍e pi耩set sze�熛ziesi靖 sze�� z這tych i osiemdziesi靖 pi耩 groszy")]
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
        [InlineData(5, "pi耩 euro")]
        [InlineData(10, "dziesi耩 euro")]
        [InlineData(11, "jedena�cie euro")]
        [InlineData(12, "dwana�cie euro")]
        [InlineData(13, "trzyna�cie euro")]
        [InlineData(21, "dwadzie�cia jeden euro")]
        [InlineData(22, "dwadzie�cia dwa euro")]
        [InlineData(23, "dwadzie�cia trzy euro")]
        [InlineData(34, "trzydzie�ci cztery euro")]
        [InlineData(102, "sto dwa euro")]
        [InlineData(105, "sto pi耩 euro")]
        [InlineData(112, "sto dwana�cie euro")]
        [InlineData(1000, "jeden tysi鉍 euro")]
        [InlineData(10000, "dziesi耩 tysi璚y euro")]
        [InlineData(1111, "jeden tysi鉍 sto jedena�cie euro")]
        [InlineData(1_000_022, "jeden milion dwadzie�cia dwa euro")]
        [InlineData(0.23, "zero euro i dwadzie�cia trzy centy")]
        [InlineData(0.01, "zero euro i jeden cent")]
        [InlineData(0.02, "zero euro i dwa centy")]
        [InlineData(0.03, "zero euro i trzy centy")]
        [InlineData(0.04, "zero euro i cztery centy")]
        [InlineData(0.05, "zero euro i pi耩 cent闚")]
        [InlineData(112.32, "sto dwana�cie euro i trzydzie�ci dwa centy")]
        public void Solve_EUR(decimal amount, string expectedWords)
        {
            var resultWords = amount.ToCurrencyPolishWords(Currency.EUR);
            Assert.Equal(expectedWords, resultWords);
        }

        [Theory]
        [InlineData(0, "zero dolar闚")]
        [InlineData(1, "jeden dolar")]
        [InlineData(2, "dwa dolary")]
        [InlineData(3, "trzy dolary")]
        [InlineData(4, "cztery dolary")]
        [InlineData(5, "pi耩 dolar闚")]
        [InlineData(10, "dziesi耩 dolar闚")]
        [InlineData(11, "jedena�cie dolar闚")]
        [InlineData(12, "dwana�cie dolar闚")]
        [InlineData(13, "trzyna�cie dolar闚")]
        [InlineData(21, "dwadzie�cia jeden dolar闚")]
        [InlineData(22, "dwadzie�cia dwa dolary")]
        [InlineData(23, "dwadzie�cia trzy dolary")]
        [InlineData(34, "trzydzie�ci cztery dolary")]
        [InlineData(102, "sto dwa dolary")]
        [InlineData(105, "sto pi耩 dolar闚")]
        [InlineData(112, "sto dwana�cie dolar闚")]
        [InlineData(1000, "jeden tysi鉍 dolar闚")]
        [InlineData(10000, "dziesi耩 tysi璚y dolar闚")]
        [InlineData(1111, "jeden tysi鉍 sto jedena�cie dolar闚")]
        [InlineData(1_000_022, "jeden milion dwadzie�cia dwa dolary")]
        [InlineData(0.23, "zero dolar闚 i dwadzie�cia trzy centy")]
        [InlineData(0.01, "zero dolar闚 i jeden cent")]
        [InlineData(0.02, "zero dolar闚 i dwa centy")]
        [InlineData(0.03, "zero dolar闚 i trzy centy")]
        [InlineData(0.04, "zero dolar闚 i cztery centy")]
        [InlineData(0.05, "zero dolar闚 i pi耩 cent闚")]
        [InlineData(112.32, "sto dwana�cie dolar闚 i trzydzie�ci dwa centy")]
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
        [InlineData(5, "pi耩 rupii")]
        [InlineData(10, "dziesi耩 rupii")]
        [InlineData(11, "jedena�cie rupii")]
        [InlineData(12, "dwana�cie rupii")]
        [InlineData(13, "trzyna�cie rupii")]
        [InlineData(21, "dwadzie�cia jeden rupii")]
        [InlineData(22, "dwadzie�cia dwie rupie")]
        [InlineData(23, "dwadzie�cia trzy rupie")]
        [InlineData(34, "trzydzie�ci cztery rupie")]
        [InlineData(102, "sto dwie rupie")]
        [InlineData(105, "sto pi耩 rupii")]
        [InlineData(112, "sto dwana�cie rupii")]
        [InlineData(1000, "jeden tysi鉍 rupii")]
        [InlineData(10000, "dziesi耩 tysi璚y rupii")]
        [InlineData(1111, "jeden tysi鉍 sto jedena�cie rupii")]
        [InlineData(1_000_022, "jeden milion dwadzie�cia dwie rupie")]
        [InlineData(0.23, "zero rupii i dwadzie�cia trzy pajsy")]
        [InlineData(0.01, "zero rupii i jedna pajsa")]
        [InlineData(0.02, "zero rupii i dwie pajsy")]
        [InlineData(0.03, "zero rupii i trzy pajsy")]
        [InlineData(0.04, "zero rupii i cztery pajsy")]
        [InlineData(0.05, "zero rupii i pi耩 pajs")]
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