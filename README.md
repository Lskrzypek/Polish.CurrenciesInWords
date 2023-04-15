# Polish.CurrenciesInWords
Friendly library to convert amounts to Polish words in specified currency. 

```c
Console.WriteLine(151.23.ToCurrencyPolishWords());

// sto pięćdziesiąt jeden złotych i dwadzieścia trzy grosze
```

Polish.NumberInWords offers following features:

### Specify a currency

```c
151.23.ToCurrencyPolishWords(Currency.USD);

// sto pięćdziesiąt jeden dolarów i dwadzieścia trzy centy
```

### All 7 Polish cases: Nominative, Genitive, Dative, Accusative, Instrumental, Locative, Vocative

```c
151.23.ToCurrencyPolishWords()
    .Case(Case.Dative)

// stu pięćdziesięciu jeden złotym i dwudziestu trzem groszom
```

### Configure returned text

```c
151.23.ToCurrencyPolishWords()
    .Write(x => $"{x.DaysCountInWords} {x.MonthInWords} {x.YearsCountInWords} {x.YearsInWords}");
    
// sto pięćdziesiąt jeden zł (PLN)
```

## Others
See my others libraries:
- [https://github.com/Lskrzypek/Polish.NumberInWords](Polish.NumbersInWords)
- [https://github.com/Lskrzypek/Polish.DatesInWords](Polish.DatesInWords)
