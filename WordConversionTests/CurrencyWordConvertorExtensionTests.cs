using Bee.NumberToWords;
using Bee.NumberToWords.Enums;
using NUnit.Framework;

namespace WordConversionTests
{
    public class CurrencyWordConvertorExtensionTests
    {
        [Test]
        public void ShouldReturnEnglishTextForUSDWhenValidAmountIsPassed()
        {
            const decimal input = 5678.71M;
            string actualResult = input.ToEnglishWords(Currency.USD);
            const string expectedResult = "Five thousand six hundred seventy eight USD and seventy one cents only";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ShouldReturnArabicTextForUSDWhenValidAmountIsPassed()
        {
            const decimal input = 5678.71M;
            string actualResult = input.ToArabicWords(Currency.USD);
            const string expectedResult = "خَمْسَة ألف سِتَّة مائة ثَمَانِيَة و سَبْعُونَ دولار أمريكي و وَاحِد و سَبْعُونَ سنتا فقط";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ShouldReturnEnglishTextForUSDWithUnitInPrefixWhenValidAmountIsPassed()
        {
            const decimal input = 38209.25M;
            string actualResult = input.ToEnglishWords(Currency.USD,true);
            const string expectedResult = "USD thirty eight thousand two hundred nine and twenty five cents only";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ShouldReturnArabicTextForSARWhenValidAmountIsPassed()
        {
            const decimal input = 437015.59M;
            string actualResult = input.ToArabicWords(Currency.SAR);
            const string expectedResult = "أَرْبَعَة مائة سَبْعَة و ثَلَاثُونَ ألف خَمْسَةَ عَشَرَ ريال و تِسْعَة و خَمْسُونَ هللة فقط";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ShouldReturnArabicTextForSARWhenAmountIsInMillions_3004719()
        {
            const decimal input = 3004719.54M;
            string actualResult = input.ToArabicWords(Currency.SAR);
            const string expectedResult = "ثَلَاثَة مليون أَرْبَعَة ألف سَبْعَة مائة تِسْعَةَ عَشَرَ ريال و أَرْبَعَة و خَمْسُونَ هللة فقط";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ShouldReturnArabicTextForSARWhenAmountIsInMillions_834781()
        {
            const decimal input = 834781.67M;
            string actualResult = input.ToArabicWords(Currency.SAR);
            const string expectedResult = "ثَمَانِيَة مائة أَرْبَعَة و ثَلَاثُونَ ألف سَبْعَة مائة وَاحِد و ثَمَانُونَ ريال و سَبْعَة و سِتُّونَ هللة فقط";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ShouldReturnArabicTextForSARWhenAmountIsInMillions_19834781()
        {
            const decimal input = 19834781.67M;
            string actualResult = input.ToArabicWords(Currency.SAR);
            const string expectedResult = "تِسْعَةَ عَشَرَ مليون ثَمَانِيَة مائة أَرْبَعَة و ثَلَاثُونَ ألف سَبْعَة مائة وَاحِد و ثَمَانُونَ ريال و سَبْعَة و سِتُّونَ هللة فقط";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
