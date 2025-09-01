# Number To Text

Bee.NumbertoWords is a light weight C# library for number to text conversion with currency support. 
Importantly it supports arabic for Saudi Riyal out of the box.

##### Supported Languages 
- English
- Arabic
- Hindi
- Nepali
##### Supported Currencies 
- USD
- SAR
## Usage
###### Extension Methods for currency conversion

```csharp
const decimal input = 5678.71M;
string result = input.ToArabicWords(Currency.USD);
//output "خَمْسَة ألف سِتَّة مائة ثَمَانِيَة و سَبْعُونَ دولار أمريكي و وَاحِد و سَبْعُونَ سنتا فقط"
string resultEng = input.ToEnglishWords(Currency.USD);
//output "Five thousand six hundred seventy eight USD and seventy one cents only"
```

###### Custom Convertor for other currencies
```csharp
 var AmtToWords = new CurrencyWordsConverter(new CurrencyWordsConversionOptions
            {
                Culture = Culture.International,
                OutputFormat = OutputFormat.English,
                CurrencyUnit = "rupees",
                SubCurrencyUnit = "paisa",
                CurrencyUnitSeparator = "and"
            });

string actualResult = AmtToWords.ToWords(32152.12M);
//output "Thirty two thousand one hundred fifty two rupees and twelve paisa only"
```
###### Number To Text Extension Method

```csharp
const decimal input = 5678.71M;
string result = input.ToWords();
//output "Five thousand six hundred seventy eight point seven one"
```



## License

MIT

**Free Software, Hell Yeah!**





<!-- Security scan triggered at 2025-09-02 01:05:09 -->

<!-- Security scan triggered at 2025-09-02 01:51:31 -->