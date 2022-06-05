using huita.Extensions;
using huita.Utilits;

namespace huita.Providers
{
    public static class BrowserProvider
    {
        public static string Browser => Config.Read.ByKey("browser");
    }
}
