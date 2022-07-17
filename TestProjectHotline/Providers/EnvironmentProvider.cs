using TestProjectHotline.Extensions;
using TestProjectHotline.Utilits;

namespace TestProjectHotline.Providers
{
    public static class EnvironmentProvider
    {
        public static string HotLineEnv => Config.Read.ByKey("HotLineEnv");
    }
}
