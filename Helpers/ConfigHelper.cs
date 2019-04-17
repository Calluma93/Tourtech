using System.Configuration;

namespace Tourtech.Helpers
{
    public static class ConfigHelper
    {
        public static string RootUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["RootUrl"];
            }
        }
    }
}