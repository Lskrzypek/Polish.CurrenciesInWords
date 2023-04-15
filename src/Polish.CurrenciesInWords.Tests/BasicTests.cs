using Polish.CurrenciesInWords;
using Polish.NumbersInWords;

namespace Polish.Currencies.Tests
{
    public class BasicTests
    {
        [Fact]
        public void ToWords_default()
        {
            decimal number = 105.99M;

            var words = number.ToCurrencyPolishWords();

            Assert.Equal("sto pięć złotych i dziewięćdziesiąt dziewięć groszy", words);
        }

        [Fact]
        public void ToWords_other_currency()
        {
            var number = 22.38;

            var words = number.ToCurrencyPolishWords(Currency.USD);

            Assert.Equal("dwadzieścia dwa dolary i trzydzieści osiem centów", words);
        }

        [Fact]
        public void ToWords_other_case()
        {
            var number = 22.38;

            var words = number.ToCurrencyPolishWords().Case(Case.Dative);

            Assert.Equal("dwudziestu dwóm złotym i trzydziestu ośmiu groszom", words);
        }

        [Fact]
        public void ToWords_other_currency_and_other_case()
        {
            var number = 22.38;

            var words = number.ToCurrencyPolishWords(Currency.USD).Case(Case.Dative);

            Assert.Equal("dwudziestu dwóm dolarom i trzydziestu ośmiu centom", words);
        }

        [Fact]
        public void ToWords_default_with_format()
        {
            decimal number = 105.99M;

            var words = number.ToCurrencyPolishWords()
                .Write(x => $"{x.MainUnitAmountInWords} {x.CurrencySymbol} ({x.CurrencyISO})");

            Assert.Equal("sto pięć zł (PLN)", words);
        }

        [Fact]
        public void ToWords_default_with_format_all()
        {
            var number = 1;

            var currencyElements = number.ToCurrencyPolishWords().CurrencyElements;
            var words = currencyElements.CurrencyISO + " " +
                currencyElements.CurrencySymbol + " " +
                currencyElements.MainUnitAmount + " " +
                currencyElements.MainUnitInWords + " " +
                currencyElements.MainUnitAmountInWords + " " +
                currencyElements.FractionalUnitAmount + " " +
                currencyElements.FractionalUnitInWords + " " +
                currencyElements.FractionalUnitAmountInWords + " " +
                currencyElements.Amount;

            Assert.Equal("PLN zł 1 złoty jeden 0 groszy zero 1", words);
        }

        [Fact]
        public void ToWords_default_with_format_all_other_currency_and_other_case()
        {
            var number = 1;

            var currencyElements = number.ToCurrencyPolishWords(Currency.USD).Case(Case.Dative).CurrencyElements;
            var words = currencyElements.CurrencyISO + " " +
                currencyElements.CurrencySymbol + " " +
                currencyElements.MainUnitAmount + " " +
                currencyElements.MainUnitInWords + " " +
                currencyElements.MainUnitAmountInWords + " " +
                currencyElements.FractionalUnitAmount + " " +
                currencyElements.FractionalUnitInWords + " " +
                currencyElements.FractionalUnitAmountInWords + " " +
                currencyElements.Amount;

            Assert.Equal("USD $ 1 dolarowi jednemu 0 centom zeru 1", words);
        }

        [Fact]
        public void ToWords_float_default()
        {
            float number = 105.99f;

            var words = number.ToCurrencyPolishWords();

            Assert.Equal("sto pięć złotych i dziewięćdziesiąt dziewięć groszy", words);
        }

        [Fact]
        public void ToWords_double_default()
        {
            double number = 105.99;

            var words = number.ToCurrencyPolishWords();

            Assert.Equal("sto pięć złotych i dziewięćdziesiąt dziewięć groszy", words);
        }

        [Fact]
        public void ToWords_double_default_with_to_much_precision()
        {
            double number = 105.989999999;

            var words = number.ToCurrencyPolishWords();

            Assert.Equal("sto pięć złotych i dziewięćdziesiąt dziewięć groszy", words);
        }
    }
}
