namespace Common.StringExtensions.Conditionals
{
    public static class WhenExtension
    {
        public static string When(this string instance, bool condition)
            => condition ? instance : string.Empty;
    }
}
