using TestProjectEtsy.Extensions;
using TestProjectEtsy.Utilits;

namespace TestProjectEtsy.Providers
{
    public static class EnvironmentProvider
    {
        public static string HotLineEnv => Config.Read.ByKey("HotLineEnv");
    }
}
