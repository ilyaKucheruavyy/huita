using System.Reflection;

namespace TestProjectEtsy.Utilits
{
    public static class Config
    {
        public static string Read = Assembly.GetCallingAssembly().Location;
    }
}
