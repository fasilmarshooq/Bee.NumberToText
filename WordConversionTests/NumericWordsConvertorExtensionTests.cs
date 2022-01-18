using Bee.NumberToWords;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordConversionTests
{
    public class NumericWordsConvertorExtensionTests
    {
        [Test]
        public void ShouldReturnEnglishTextWhenValidAmountIsPassed()
        {
            const decimal input = 5678.71M;
            string actualResult = input.ToWords();
            const string expectedResult = "Five thousand six hundred seventy eight point seven one";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
