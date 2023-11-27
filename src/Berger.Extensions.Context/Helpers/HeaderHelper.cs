namespace Berger.Extensions.Context
{
    public static class HeaderHelper
    {
        public static string GetValue(this IHeaderDictionary headers, string key)
        {
            return headers[key].ToString();
        }
    }
}