using TestProjectEtsy.Extensions;
using TestProjectEtsy.Utilits;

namespace TestProjectEtsy.Providers
{
    public static class BrowserProvider
    {
        public static string Browser => Config.Read.ByKey("browser");
    }
}
