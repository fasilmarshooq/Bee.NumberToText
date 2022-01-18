using Bee.NumberToWords.Enums;
using Bee.NumberToWords.Resources;

namespace Bee.NumberToWords
{
    public static class CurrencyWordConvertorExtension
    {
        public static string ToEnglishWords(this decimal number, Currency currency, bool unitInPrefix = false)
        {
            var currencyResource = CurrencyResources.EnglishCurrencyConvertor[currency];
            if (unitInPrefix)
            {
                currencyResource.CurrencyNotationType = NotationType.Prefix;
            }
            return new CurrencyWordsConverter(currencyResource).ToWords(number);
        }

        public static string ToArabicWords(this decimal number, Currency currency)
        {
            return new CurrencyWordsConverter(CurrencyResources.ArabicCurrencyConvertor[currency]).ToWords(number);
        }
    }
}
