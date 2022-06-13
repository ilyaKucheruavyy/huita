using TestProjectEtsy.Extensions;
using TestProjectEtsy.Utilits;

namespace TestProjectEtsy.Providers
{
    public static class EnvironmentProvider
    {
        public static string EtsyEnv => Config.Read.ByKey("etsyEnv");
        public static string SecondEnv => Config.Read.ByKey("secondEnv");
    }
}
