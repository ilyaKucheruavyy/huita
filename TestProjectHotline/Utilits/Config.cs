using System.Reflection;

namespace TestProjectHotline.Utilits
{
    public static class Config
    {
        public static string Read = Assembly.GetCallingAssembly().Location;
    }
}
