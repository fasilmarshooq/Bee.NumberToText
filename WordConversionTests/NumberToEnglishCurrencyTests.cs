using Bee.NumberToWords;
using Bee.NumberToWords.Enums;
using NUnit.Framework;

namespace WordConversionTests
{
    public class NumberToEnglishCurrencyTests
    {
        [Test]
        public void ShouldReturnEnglishTextWhenValidAmountIsPassed()
        {
            var AmtToWords = new CurrencyWordsConverter(new CurrencyWordsConversionOptions
            {
                Culture = Culture.International,
                OutputFormat = OutputFormat.English,
                CurrencyUnit = "rupees",
                SubCurrencyUnit = "paisa"
            });

            string actualResult = AmtToWords.ToWords(32152M);
            const string expectedResult = "Thirty two thousand one hundred fifty two rupees only";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ShouldReturnEnglishTextWhenValidAmountWithDecimalIsPassed()
        {
            var AmtToWords = new CurrencyWordsConverter(new CurrencyWordsConversionOptions
            {
                Culture = Culture.International,
                OutputFormat = OutputFormat.English,
                CurrencyUnit = "rupees",
                SubCurrencyUnit = "paisa",
                CurrencyUnitSeparator = "and"
            });

            string actualResult = AmtToWords.ToWords(32152.12M);
            const string expectedResult = "Thirty two thousand one hundred fifty two rupees and twelve paisa only";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}