using static System.Xml.Linq.XDocument;

namespace Common.StringExtensions.Formatters
{
    public static class FormatXmlExtension
    {
        public static string FormatXml(this string instance)
        {
            try
            {
                return Parse(instance).ToString();
            }
            catch
            {
                return instance;
            }
        }
    }
}
