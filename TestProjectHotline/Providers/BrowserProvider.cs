using TestProjectHotline.Extensions;
using TestProjectHotline.Utilits;

namespace TestProjectHotline.Providers
{
    public static class BrowserProvider
    {
        public static string Browser => Config.Read.ByKey("browser");
    }
}
