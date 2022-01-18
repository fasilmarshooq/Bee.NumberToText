using Bee.NumberToWords;
using Bee.NumberToWords.Enums;
using NUnit.Framework;

namespace WordConversionTests
{
    public class NumberToArabicCurrencyConversionTests
    {
        [Test]
        public void ShouldReturnArabicTextWhenValidAmountIsPassed()
        {
            var AmtToWords = new CurrencyWordsConverter(new CurrencyWordsConversionOptions
            {
                Culture = Culture.Arabic,
                OutputFormat = OutputFormat.Arabic,
                CurrencyUnitSeparator = "و",
                CurrencyUnit = "دولار أمريكي",
                SubCurrencyUnit = "سنتا",
                EndOfWordsMarker = "فقط"
            });

            string actualResult = AmtToWords.ToWords(5678.71M);
            const string expectedResult = "خَمْسَة ألف سِتَّة مائة ثَمَانِيَة و سَبْعُونَ دولار أمريكي و وَاحِد و سَبْعُونَ سنتا فقط";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
