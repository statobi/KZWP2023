namespace IDEA.Logistyka.Walidatory
{
    internal static class RozszerzeniaWalidacyjne
    {
        public static bool StringToIntParser(this string someIntInString)
            => !int.TryParse(someIntInString, out int result);

        public static bool WalidatorDlugosciZnakowMax(this string someString, int requiredLength)
            => someString.Length > requiredLength;
        
        public static bool WalidatorDlugosciZnakowRowne(this string someString, int requiredLength)
            => someString.Length != requiredLength;
    }
}
