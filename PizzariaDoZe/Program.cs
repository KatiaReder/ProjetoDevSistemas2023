using System.Configuration;
using System.Data.Common;
using System.Globalization;


namespace PizzariaDoZe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // No .NET 2.1 ou posterior os provedores não são mais registrados automaticamente no DbProviderFactories
            // Após instalar os pacotes via NuGet, realizar o registro manualmente no DbProviderFactories
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);



            // ? indica que o valor pode ser nulo
            // no ternário estamos tratando para isso não ocorrer
            string? auxIdiomaRegiao = ConfigurationManager.AppSettings.Get("Idioma"); // en-US, es, pt-BR, etc
           //ajusta o idioma/região
           //ajusta o idioma/região
           //o ! afirma que o valor já foi tratado e não será nulo aqui
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new janelaPrincipal());
        }
    }
}