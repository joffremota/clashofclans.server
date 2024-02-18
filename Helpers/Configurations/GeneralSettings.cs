namespace clashofclans.server.Helpers.Configurations
{
    public class GeneralSettings
    {
        public API_KEY API_KEY { get; set; }

        public string ObterToken()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json") // Este é o arquivo padrão
                .AddJsonFile("appsettings.development.json", optional: true) // Adiciona o arquivo development.json, se existir
                .Build();

            // Obtém o valor do token
            var token = configuration["API_KEY:Token"];

            return token ?? "Token not found";
        }
    }

    public class API_KEY
    {
        public string token { private get; set; }
    }
}
