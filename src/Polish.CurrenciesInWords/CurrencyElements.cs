using Polish.NumbersInWords;
using System;

namespace Polish.CurrenciesInWords
{
    internal class CurrencyElements : ICurrencyElements
    {
        public decimal Amount { get; private set; }

        public long MainUnitAmount { get; private set; }

        public string MainUnitAmountInWords => _mainUnitNumberElements.ToString();

        public string MainUnitInWords => _mainUnitNumberElements.GetPhraseAfterNumber(_currency.MainUnitWord);

        public short FractionalUnitAmount { get; private set; }

        public string FractionalUnitAmountInWords => _fractionalUnitNumberElements.ToString();

        public string FractionalUnitInWords => _fractionalUnitNumberElements.GetPhraseAfterNumber(_currency.FractionalUnitWord);

        public string CurrencyISO => _currency.ISO;

        public string CurrencySymbol => _currency.Symbol;

        private ICurrency _currency;
        private Case _case;
        private INumberElements _mainUnitNumberElements;
        private INumberElements _fractionalUnitNumberElements;

        public CurrencyElements(decimal amount, ICurrency currency, Case @case)
        {
            _currency = currency;
            Amount = amount;
            _case = @case;

            MainUnitAmount = (long)Math.Floor(amount);

            FractionalUnitAmount = (short)(Math.Round(amount - MainUnitAmount, 2) * 100);

            _mainUnitNumberElements = MainUnitAmount
                    .ToPolishWords()
                    .Case(_case)
                    .Gender(_currency.MainUnitGender)
                    .WithOneBeforeThousand()
                    .NumberElements;

            _fractionalUnitNumberElements = FractionalUnitAmount
                    .ToPolishWords()
                    .Case(_case)
                    .Gender(_currency.FractionalUnitGender)
                    .NumberElements;
        }
    }
}
