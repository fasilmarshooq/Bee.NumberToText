namespace Bee.NumberToWords
{
    public static class NumericWordsConvertorExtension
    {
        public static string ToWords(this decimal input)
        {
            return new NumericWordsConverter().ToWords(input);
        }
    }
}
