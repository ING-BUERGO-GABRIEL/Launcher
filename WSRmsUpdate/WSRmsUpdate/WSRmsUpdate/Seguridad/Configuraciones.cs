using Microsoft.Extensions.Configuration;

namespace WSRmsUpdate.Seguridad
{
    internal static class Configuraciones
    {
        public static IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        public static string ObtenerValor(string clave)
        {
            return configuration[clave];
        }
    }
}

