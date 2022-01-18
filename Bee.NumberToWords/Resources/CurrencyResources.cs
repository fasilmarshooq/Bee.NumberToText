using Bee.NumberToWords.Enums;
using System.Collections.Generic;

namespace Bee.NumberToWords.Resources
{
    public static class CurrencyResources
    {
        public static Dictionary<Currency, CurrencyWordsConversionOptions> EnglishCurrencyConvertor { get; set; } = new()
        {
            {
                Currency.USD,
                new CurrencyWordsConversionOptions()
                {
                    Culture = Culture.International,
                    OutputFormat = OutputFormat.English,
                    CurrencyUnitSeparator = "and",
                    CurrencyUnit = "USD",
                    SubCurrencyUnit = "cents",
                    EndOfWordsMarker = "only"
                }
            },
            {
                Currency.SAR,
                new CurrencyWordsConversionOptions()
                {
                    Culture = Culture.International,
                    OutputFormat = OutputFormat.English,
                    CurrencyUnitSeparator = "and",
                    CurrencyUnit = "SAR",
                    SubCurrencyUnit = "halalas",
                    EndOfWordsMarker = "only"
                }
            }
        };

        public static Dictionary<Currency, CurrencyWordsConversionOptions> ArabicCurrencyConvertor { get; set; } = new()
        {
            {
                Currency.USD,
                new CurrencyWordsConversionOptions()
                {
                    Culture = Culture.Arabic,
                    OutputFormat = OutputFormat.Arabic,
                    CurrencyUnitSeparator = "و",
                    CurrencyUnit = "دولار أمريكي",
                    SubCurrencyUnit = "سنتا",
                    EndOfWordsMarker = "فقط"
                }
            },
            {
                Currency.SAR,
                new CurrencyWordsConversionOptions()
                {
                    Culture = Culture.Arabic,
                    OutputFormat = OutputFormat.Arabic,
                    CurrencyUnitSeparator = "و",
                    CurrencyUnit = "ريال",
                    SubCurrencyUnit = "هللة",
                    EndOfWordsMarker = "فقط"
                }
            }
        };
    }
}
