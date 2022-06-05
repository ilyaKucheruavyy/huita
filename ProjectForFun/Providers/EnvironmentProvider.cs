using huita.Extensions;
using huita.Utilits;

namespace huita.Providers
{
    public static class EnvironmentProvider
    {
        public static string EtsyEnv => Config.Read.ByKey("etsyEnv");
        public static string SecondEnv => Config.Read.ByKey("secondEnv");
    }
}
