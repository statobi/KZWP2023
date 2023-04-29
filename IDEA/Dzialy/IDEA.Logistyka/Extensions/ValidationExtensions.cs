namespace IDEA.Logistyka.Walidatory
{
    internal static class ValidationExtensions
    {
        public static bool StringToIntParser(this string someIntInString)
            => !int.TryParse(someIntInString, out int result);
        
        public static bool StringToDoubleParser(this string someIntInString)
            => !double.TryParse(someIntInString, out double result);

        public static bool StringLengthValidatorMax(this string someString, int requiredLength)
            => someString.Length > requiredLength;
        
        public static bool StringLengthValidatorEqual(this string someString, int requiredLength)
            => someString.Length != requiredLength;

        public static bool IsGreatherThan(this double someNumber, double referenceNumber)
            => someNumber > referenceNumber;
    }
}
