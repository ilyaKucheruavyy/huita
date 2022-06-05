using System.Reflection;

namespace huita.Utilits
{
    public static class Config
    {
        public static string Read = Assembly.GetCallingAssembly().Location;
    }
}
